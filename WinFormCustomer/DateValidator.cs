using System;

namespace WinFormCustomer
{
    public class DateValidator
    {
        public DateTime ConvertCostumerString(DateTime date, string itemToConvert)
        {
            return date = Convert.ToDateTime(itemToConvert);
        }

    }
}