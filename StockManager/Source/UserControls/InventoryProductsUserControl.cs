using StockManager.Source.Components;
using StockManager.Source.Forms;
using StockManager.Services.Source;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Utilities.Source;
using System.Drawing;

namespace StockManager.Source.UserControls {
  public partial class InventoryProductsUserControl : UserControl {
    private readonly MainForm _mainForm;
    private bool _hasBeenSearching = false; // Flags if the user has been searching

    public InventoryProductsUserControl(MainForm mainForm) {
      InitializeComponent();

      // Pass the main form to this UC to handle with product location UC
      _mainForm = mainForm;

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;
      this.SetTranslatedPhrases();
      this.LoadProductsAsync().Wait();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      btnCreate.Text = Phrases.GlobalCreate;
      btnDelete.Text = Phrases.GlobalDelete;
      dgvProducts.Columns[1].HeaderText = Phrases.GlobalReference;
      dgvProducts.Columns[2].HeaderText = Phrases.GlobalName;
      dgvProducts.Columns[3].HeaderText = Phrases.GlobalStock;
      dgvProducts.Columns[4].HeaderText = Phrases.GlobalCreatedAt;
      // Actions
      dgvProducts.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalEdit; // Action edit
      dgvProducts.Columns[6].CellTemplate.ToolTipText = Phrases.GlobalLocations; // Action details
      dgvProducts.Columns[7].CellTemplate.ToolTipText = Phrases.GlobalDelete; // Action delete
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadProductsAsync(string searchValue = null) {
      Spinner.InitSpinner();
      dgvProducts.Rows.Clear();

      IEnumerable<Product> products = await AppServices.ProductService
        .GetProductsAsync(searchValue);

      foreach (Product product in products) {
        dgvProducts.Rows.Add(
          product.ProductId,
          product.Reference,
          product.Name,
          product.Stock,
          Format.DateTimeFormat(product.CreatedAt)
        );
      }

      Spinner.StopSpinner();
    }

    /// <summary>
    /// Create product button click
    /// </summary>
    private void btnCreate_Click(object sender, EventArgs e) {
      ProductForm productForm = new ProductForm(this);
      productForm.ShowProductForm();
    }

    /// <summary>
    /// Delete multiple products button click
    /// </summary>
    private async void btnDelete_Click(object sender, EventArgs e) {
      DataGridViewSelectedRowCollection selectedProducts = dgvProducts.SelectedRows;

      if (selectedProducts.Count > 0) {
        int[] productIds = new int[selectedProducts.Count];

        for (int i = 0; i < selectedProducts.Count; i++) {
          productIds[i] = int.Parse(selectedProducts[i].Cells[0].Value.ToString());
        }

        await this.ActionDeleteClickAsync(productIds);
      }
    }

    /// <summary>
    /// Handle with table actions click
    /// </summary>
    private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if ((dgvProducts.SelectedRows.Count > 0) && (e.RowIndex >= 0)) {
        int productId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());

        switch (e.ColumnIndex) {
          case 5:
            await this.ActionEditClickAsync(productId);
            break;
          case 6:
            await this.ActionDetailsClickAsync(productId);
            break;
          case 7:
            await this.ActionDeleteClickAsync(new int[] { productId });
            break;
          default:
            break;
        }
      }
    }

    /// <summary>
    /// Edit product button click
    /// </summary>
    private async Task ActionEditClickAsync(int productId) {
      Spinner.InitSpinner();
      Product product = await AppServices.ProductService.GetProductByIdAsync(productId);
      Spinner.StopSpinner();

      ProductForm productForm = new ProductForm(this);
      productForm.ShowProductForm(product);
    }

    /// <summary>
    /// Show the product locations UC
    /// </summary>
    private async Task ActionDetailsClickAsync(int productId) {
      Spinner.InitSpinner();
      Product product = await AppServices.ProductService.GetProductByIdAsync(productId);
      Spinner.StopSpinner();

      _mainForm.InventoryProductsBtnViewProducLocationsClick(product);
    }

    private async Task ActionDeleteClickAsync(int[] selectedIds) {
      if ((selectedIds.Length > 0) && MessageBox.Show(
      string.Format(Phrases.ProductDialogDeleteBody, selectedIds.Length),
      Phrases.GlobalDialogDeleteTitle,
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
    ) {
        try {
          Spinner.InitSpinner();
          await AppServices.ProductService.DeleteProductAsync(selectedIds);
          Spinner.StopSpinner();

          await this.LoadProductsAsync();

        } catch (OperationErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogWarningTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
          );

        } catch (ServiceErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogErrorTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private async void pbSearchIcon_Click(object sender, EventArgs e) {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue)) {
        // sets the flag has been searching
        _hasBeenSearching = true;

        await this.LoadProductsAsync(searchValue);
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private async void btnClearSearchValue_Click(object sender, EventArgs e) {
      tbSeachText.Text = "";
      await this.LoadProductsAsync();
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
    private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == ( char )Keys.Enter) {
        this.pbSearchIcon_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      } else if (e.KeyChar == ( char )Keys.Escape) {
        this.btnClearSearchValue_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private async void tbSeachText_TextChanged(object sender, EventArgs e) {
      if (tbSeachText.Text.Length > 0) {
        btnClearSearchValue.Visible = true;

        // If the user clear all the search box text after doing some search, 
        // i need to query the DB without any search param to show all table data.
      } else if ((tbSeachText.Text.Length == 0) && _hasBeenSearching) {
        _hasBeenSearching = false;
        btnClearSearchValue.Visible = false;
        await this.LoadProductsAsync();
      }
    }
  }
}
