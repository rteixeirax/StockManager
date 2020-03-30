using StockManager.Storage.Models;
using StockManager.Types;
using StockManager.UserControls;
using StockManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms {
  public partial class ProductForm : Form {
    private int productId = 0;
    private readonly InventoryProductsUserControl inventoryProductsUserControl;

    public ProductForm(InventoryProductsUserControl inventoryProductsUserControl) {
      InitializeComponent();
      this.inventoryProductsUserControl = inventoryProductsUserControl;
    }

    /// <summary>
    /// Show User Form and set the initial values
    /// </summary>
    public void ShowProductForm(Product product = null) {
      Spinner.InitSpinner();

      // Set the productId. Means that is a edit
      this.productId = (product != null) ? product.ProductId : 0;

      // Set the Form title
      this.Text = (this.productId != 0)
        ? "Stock Manager | Edit product"
        : "Stock Manager | Create new product";

      // hide the error labels
      lbErrorReference.Visible = false;
      lbErrorName.Visible = false;

      // Edit
      if (product != null) {
        tbReference.Text = product.Reference;
        tbName.Text = product.Name;
      }

      Spinner.StopSpinner();
      this.ShowDialog();
    }

    /// <summary>
    /// Show the form errors, if any.
    /// </summary>
    private void ShowFormErrors(List<ErrorType> errors) {
      lbErrorReference.Visible = false;
      lbErrorName.Visible = false;

      foreach (ErrorType err in errors) {
        if (err.Field == "Reference") {
          lbErrorReference.Text = err.Error;
          lbErrorReference.Visible = true;
        }

        if (err.Field == "Name") {
          lbErrorName.Text = err.Error;
          lbErrorName.Visible = true;
        }
      }
    }

    /// <summary>
    /// Create/Update button click
    /// </summary>
    private async void btnSave_Click(object sender, EventArgs e) {
      try {
        Product product = new Product {
          Reference = tbReference.Text,
          Name = tbName.Text,
        };

        Spinner.InitSpinner();

        if ((this.productId != 0)) {
          product.ProductId = this.productId;
          await Program.ProductService.EditProductAsync(product);
        } else {
          await Program.ProductService.CreateProductAsync(product);
        }

        Spinner.StopSpinner();
        await this.inventoryProductsUserControl.LoadProductsAsync();

        this.Close();
      } catch (OperationErrorException ex) {
        Spinner.StopSpinner();

        if (ex.Errors.Count() > 0) {
          this.ShowFormErrors(ex.Errors);
        }
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
