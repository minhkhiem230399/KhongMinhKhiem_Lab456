using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace KhongMinhKhiem_LAB456.ViewModels
{
    public class ValidTime : ValicationAttribute
    {
        private bool isValid;

        private bool IsValid(object value)
        {
            DateTime dateTime;
            var ssValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return isValid;
        }

    }
}