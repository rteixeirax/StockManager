﻿using StockManager.Source.Components;
using StockManager.Services.Source;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Source.UserControls;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockManager.Source.Forms {
  public partial class ProductForm : Form {
    private int productId = 0;
    private readonly InventoryProductsUserControl inventoryProductsUserControl;

    public ProductForm(InventoryProductsUserControl inventoryProductsUserControl) {
      InitializeComponent();
      this.inventoryProductsUserControl = inventoryProductsUserControl;
      this.SetTranslatedPhrases();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      lbTitle.Text = Phrases.ProductInfo;
      lbReference.Text = Phrases.GlobalReference;
      lbName.Text = Phrases.GlobalName;
      btnCancel.Text = Phrases.GlobalCancel;
      btnSave.Text = Phrases.GlobalSave;
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
        ? AppInfo.GetViewTitle(Phrases.ProductEdit)
        : AppInfo.GetViewTitle(Phrases.ProductCreateNewProduct);

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
          await AppServices.ProductService.EditProductAsync(product);
        } else {
          await AppServices.ProductService.CreateProductAsync(product);
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