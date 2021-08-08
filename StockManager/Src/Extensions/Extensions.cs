using System;

using StockManager.Src.Data.Entities;
using StockManager.Src.Translations;

namespace StockManager.Src.Extensions
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

            string concat = $"{Phrases.StockMovementFrom}: {fromLocation ?? "---"}"
              + Environment.NewLine
              + $"{Phrases.StockMovementTo}: {toLocation ?? "---"}";

            return concat;
        }

        public static DateTime SetDateToBeginningOfTheDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        }

        public static DateTime SetDateToEndOfTheDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }

        public static string ShortDate(this DateTime date)
        {
            return date.ToLocalTime().ToString("dd MMM yyyy");
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
