using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCustomer
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
