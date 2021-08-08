using System;
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
    public partial class LocationForm : Form
    {
        private readonly InventoryLocationsUc _inventoryLocationsUserControl;
        private int _locationId = 0;

        public LocationForm(InventoryLocationsUc inventoryLocationsUserControl)
        {
            InitializeComponent();
            _inventoryLocationsUserControl = inventoryLocationsUserControl;
            SetTranslatedPhrases();
        }

        /// <summary>
        /// Show Location Form and set the initial values
        /// </summary>
        public void ShowLocationForm(Location location = null)
        {
            // Set the locationId. Means that is a edit
            _locationId = (location != null) ? location.LocationId : 0;

            // Set the Form title
            Text = (_locationId != 0)
              ? AppConstants.GetViewTitle(Phrases.LocationEdit)
              : AppConstants.GetViewTitle(Phrases.LocationCreate);

            // hide the error labels
            lbErrorName.Visible = false;

            // Edit
            if (location != null)
            {
                tbName.Text = location.Name;
            }

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
                Location location = new Location
                {
                    Name = tbName.Text
                };

                Spinner.InitSpinner();

                if ((_locationId != 0))
                {
                    location.LocationId = _locationId;
                    await AppServices.LocationService.EditAsync(location);
                }
                else
                {
                    await AppServices.LocationService.CreateAsync(location);
                }

                Spinner.StopSpinner();

                await _inventoryLocationsUserControl.LoadLocationsAsync();

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
            lbTitle.Text = Phrases.LocationInfo;
            lbName.Text = Phrases.GlobalName;
            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }

        /// <summary>
        /// Show the form errors, if any.
        /// </summary>
        private void ShowFormErrors(List<ErrorType> errors)
        {
            lbErrorName.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "Name")
                {
                    lbErrorName.Text = err.Error;
                    lbErrorName.Visible = true;
                }
            }
        }
    }
}
