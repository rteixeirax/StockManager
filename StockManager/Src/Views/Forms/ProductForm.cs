﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;
using StockManager.Src.Views.UserControls;

namespace StockManager.Src.Views.Forms
{
    public partial class ProductForm : Form
    {
        private readonly InventoryProductsUc _inventoryProductsUserControl;
        private int _productId = 0;

        public ProductForm(InventoryProductsUc inventoryProductsUserControl)
        {
            InitializeComponent();
            _inventoryProductsUserControl = inventoryProductsUserControl;
            SetTranslatedPhrases();
        }

        /// <summary>
        /// Show User Form and set the initial values
        /// </summary>
        public void ShowProductForm(Product product = null)
        {
            Spinner.InitSpinner();

            // Set the productId. Means that is a edit
            _productId = (product != null) ? product.ProductId : 0;

            // Set the Form title
            Text = (_productId != 0)
              ? AppConstants.GetViewTitle(Phrases.ProductEdit)
              : AppConstants.GetViewTitle(Phrases.ProductCreateNewProduct);

            // hide the error labels
            lbErrorReference.Visible = false;
            lbErrorName.Visible = false;

            // Edit
            if (product != null)
            {
                tbReference.Text = product.Reference;
                tbName.Text = product.Name;
            }

            Spinner.StopSpinner();
            ShowDialog();
        }

        /// <summary>
        /// Close button click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Create/Update button click
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product
                {
                    Reference = tbReference.Text,
                    Name = tbName.Text,
                };

                Spinner.InitSpinner();

                if ((_productId != 0))
                {
                    product.ProductId = _productId;
                    await AppServices.ProductService.EditAsync(product);
                }
                else
                {
                    await AppServices.ProductService
                      .CreateAsync(product, Program.LoggedInUser.UserId);
                }

                Spinner.StopSpinner();
                await _inventoryProductsUserControl.LoadProductsAsync();

                Close();
            }
            catch (OperationErrorException ex)
            {
                Spinner.StopSpinner();

                if (ex.Errors.Any())
                {
                    ShowFormErrors(ex.Errors);
                }
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Remove the annoying beep
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnSave.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Remove the annoying beep
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnCancel.PerformClick();
            }
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            lbTitle.Text = Phrases.ProductInfo;
            lbReference.Text = Phrases.GlobalReference;
            lbName.Text = Phrases.GlobalName;
            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }

        /// <summary>
        /// Show the form errors, if any.
        /// </summary>
        private void ShowFormErrors(List<ErrorType> errors)
        {
            lbErrorReference.Visible = false;
            lbErrorName.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "Reference")
                {
                    lbErrorReference.Text = err.Error;
                    lbErrorReference.Visible = true;
                }

                if (err.Field == "Name")
                {
                    lbErrorName.Text = err.Error;
                    lbErrorName.Visible = true;
                }
            }
        }
    }
}
