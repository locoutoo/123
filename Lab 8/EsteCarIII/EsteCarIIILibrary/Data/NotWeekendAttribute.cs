using System;
using System.ComponentModel.DataAnnotations;

namespace EstCarIIILibrary.Models
{
    public class NotWeekendAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return false;
            return true;
        }
    }
}
