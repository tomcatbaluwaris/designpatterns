using System;

namespace InterfaceCustomer.Properties
{
    public interface ICustomer
    {
        string CustomerName { get; set; }
        decimal BillAmount { get; set; }
        string Address { get; set; }

        DateTime BillDate { get; set; }
        string PhoneNumber { get; set; }

        void Validate();
    }
}