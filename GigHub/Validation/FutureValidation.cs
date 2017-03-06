﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace GigHub.Validation
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;

            var isValid = DateTime.TryParseExact(
                Convert.ToString(value),
                "dd MMM yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime);

            return isValid && dateTime > DateTime.Now;
        }
    }
    public class FutureTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;

            var isValid = DateTime.TryParseExact(
                Convert.ToString(value),
                "HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime);

            return isValid && dateTime > DateTime.Now;
        }
    }
}