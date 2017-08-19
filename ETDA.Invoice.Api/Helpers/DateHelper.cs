using System;
using System.Globalization;

namespace ETDA.Invoice.Api.Helpers
{
    public static class DateHelper
    {
        public static DateTime ConvertToDateTime(string dateTime)
        {
            if (string.IsNullOrEmpty(dateTime)) throw new ArgumentException(dateTime);

            var dateTimeFormat = new CultureInfo("th-TH", false).DateTimeFormat;
            return Convert.ToDateTime(dateTime, dateTimeFormat);
        }

        public static string GetThaiDateText(string date)
        {
            if (!string.IsNullOrEmpty(date))
            {
                var cultureInfo = new CultureInfo("th-TH");
                var datetime = DateHelper.ConvertToDateTime(date);
                return datetime.ToString("dd MMMM yyyy", new CultureInfo("th-TH").DateTimeFormat);
            }
            return null;
        }
    }
}