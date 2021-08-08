﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Extensions;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;
using StockManager.Src.Views.Forms;

namespace StockManager.Src.Views.UserControls
{
    public partial class InventoryProductsUc : UserControl
    {
        private readonly MainForm _mainForm;
        private bool _hasBeenSearching = false; // Flags if the user has been searching
        private IEnumerable<Product> _products;

        public InventoryProductsUc(MainForm mainForm)
        {
            InitializeComponent();

            // Pass the main form to this UC to handle with product location UC
            _mainForm = mainForm;

            // Hide the X button on the search textbox
            btnClearSearchValue.Visible = false;
            SetTranslatedPhrases();
            LoadProductsAsync().Wait();
        }

        /// <summary>
        /// Fill the Data Grid View
        /// </summary>
        public async Task LoadProductsAsync()
        {
            Spinner.InitSpinner();
            dgvProducts.Rows.Clear();

            IEnumerable<Product> products = await AppServices
                .ProductService.GetAllAsync(new ProductOptions() { SearchValue = tbSeachText.Text });

            _products = products;

            products.ToList().ForEach((product) => {
                dgvProducts.Rows.Add(
                  product.ProductId,
                  product.Reference,
                  product.Name,
                  product.Stock,
                  product.CreatedAt.ShortDateWithTime()
                );
            });

            Spinner.StopSpinner();
        }

        /// <summary>
        /// Delete button click
        /// </summary>
        private async Task ActionDeleteClickAsync(int[] selectedIds)
        {
            if ((selectedIds.Length > 0) && MessageBox.Show(
            string.Format(Phrases.ProductDialogDeleteBody, selectedIds.Length),
            Phrases.GlobalDialogDeleteTitle,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
          )
            {
                try
                {
                    Spinner.InitSpinner();
                    await AppServices.ProductService.DeleteAsync(selectedIds);
                    Spinner.StopSpinner();

                    await LoadProductsAsync();
                }
                catch (OperationErrorException ex)
                {
                    Spinner.StopSpinner();

                    MessageBox.Show(
                      $"{ex.Errors[0].Error}",
                      Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                    );
                }
                catch (ServiceErrorException ex)
                {
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
        /// Show the product locations UC
        /// </summary>
        private async Task ActionDetailsClickAsync(int productId)
        {
            Spinner.InitSpinner();
            Product product = await AppServices.ProductService.GetByIdAsync(productId);
            Spinner.StopSpinner();

            _mainForm.ShowProducLocationsFromProductsUc(product);
        }

        /// <summary>
        /// Edit product button click
        /// </summary>
        private async Task ActionEditClickAsync(int productId)
        {
            Spinner.InitSpinner();
            Product product = await AppServices.ProductService.GetByIdAsync(productId);
            Spinner.StopSpinner();

            ProductForm productForm = new ProductForm(this);
            productForm.ShowProductForm(product);
        }

        /// <summary>
        /// Clear search value on picture box click
        /// </summary>
        private async void btnClearSearchValue_Click(object sender, EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadProductsAsync();
        }

        /// <summary>
        /// Create product button click
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(this);
            productForm.ShowProductForm();
        }

        private async void btnCreatePdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_products.Any())
                {
                    MessageBox.Show(Phrases.GlobalDialogExportWarningBody, Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show(Phrases.GlobalDialogExportBody, Phrases.GlobalDialogExportTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Spinner.InitSpinner();

                    await AppServices.ProductService.ExportProductsToPDFAsync(_products);

                    Spinner.StopSpinner();
                }
            }
            catch (ServiceErrorException ex)
            {
                Spinner.StopSpinner();

                MessageBox.Show($"{ex.Errors[0].Error}", Phrases.GlobalDialogErrorTitle,
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Delete multiple products button click
        /// </summary>
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedItems = dgvProducts.SelectedRows;

            if (selectedItems.Count > 0)
            {
                int[] arrayOfIds = new int[selectedItems.Count];

                for (int i = 0; i < selectedItems.Count; i++)
                {
                    arrayOfIds[i] = int.Parse(selectedItems[i].Cells[0].Value.ToString());
                }

                await ActionDeleteClickAsync(arrayOfIds);
            }
        }

        /// <summary>
        /// Handle with table actions click
        /// </summary>
        private async void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvProducts.SelectedRows.Count > 0) && (e.RowIndex >= 0))
            {
                int productId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());

                switch (e.ColumnIndex)
                {
                    case 5:
                        await ActionEditClickAsync(productId);
                        break;

                    case 6:
                        await ActionDetailsClickAsync(productId);
                        break;

                    case 7:
                        await ActionDeleteClickAsync(new int[] { productId });
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Search button click
        /// </summary>
        private async void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSeachText.Text))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;

                await LoadProductsAsync();
            }
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            btnCreatePdf.Text = Phrases.GlobalExportToPDF;
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
        /// Call search button click when pressed enter in the textbox
        /// </summary>
        private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ( char )Keys.Enter)
            {
                pbSearchIcon_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
            else if (e.KeyChar == ( char )Keys.Escape)
            {
                btnClearSearchValue_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
        }

        /// <summary>
        /// Show/Hide the X button on the search textbox
        /// </summary>
        private async void tbSeachText_TextChanged(object sender, EventArgs e)
        {
            if (tbSeachText.Text.Length > 0)
            {
                btnClearSearchValue.Visible = true;

                // If the user clear all the search box text after doing some search, i need to
                // query the DB without any search param to show all table data.
            }
            else if ((tbSeachText.Text.Length == 0) && _hasBeenSearching)
            {
                _hasBeenSearching = false;
                btnClearSearchValue.Visible = false;
                await LoadProductsAsync();
            }
        }
    }
}
