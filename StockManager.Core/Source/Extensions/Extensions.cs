using System;

using StockManager.Core.Source.Models;
using StockManager.Translations.Source;

namespace StockManager.Core.Source.Extensions
{
    public static class Extensions
    {
        public static string ConcatMovementString(this StockMovement stockMovement)
        {
            string fromLocation = (stockMovement.FromLocation != null)
               ? stockMovement.FromLocation.Name
               : stockMovement.FromLocationName;

            string toLocation = (stockMovement.ToLocation != null)
              ? stockMovement.ToLocation.Name
              : stockMovement.ToLocationName;

            // Between locations
            if (!string.IsNullOrEmpty(fromLocation) && !string.IsNullOrEmpty(toLocation))
            {
                return $"{Phrases.StockMovementFrom}: {fromLocation}"
                  + Environment.NewLine
                  + $"{Phrases.StockMovementTo}: {toLocation}";
            }

            // Inside main location (entry)
            if (string.IsNullOrEmpty(fromLocation) && !string.IsNullOrEmpty(toLocation))
            {
                return $"{Phrases.StockMovementTo}: {toLocation}";
            }

            // Removed from location
            return $"{Phrases.StockMovementFrom}: {fromLocation}";
        }

        public static string ShortDateWithTime(this DateTime? date)
        {
            if (date == null)
            {
                return "";
            }

            return date?.ToLocalTime().ToString("dd MMM yyyy, HH:mm:ss");
        }
    }
}
