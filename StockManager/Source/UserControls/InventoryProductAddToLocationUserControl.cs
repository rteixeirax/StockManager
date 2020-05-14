using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.UserControls {
  public partial class InventoryProductAddToLocationUserControl : UserControl {
    public InventoryProductAddToLocationUserControl() {
      InitializeComponent();
      this.SetTranslatedPhrases();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      btnback.Text = "Back";
      btnAddLocation.Text = "Add";
      //btnViewMovements.Text = "View Movements";
      lbLocation.Text = "Location";
      lbQty.Text = "Qty";
      lbMinStock.Text = "Min.Stock";
      lbProductLocationsTitle.Text = "Locations";
      dgvProductLocations.Columns[1].HeaderText = "Location";
      dgvProductLocations.Columns[2].HeaderText = "Stock";
      dgvProductLocations.Columns[3].HeaderText = "Min.Stock";
    }
  }
}
