using System;
using InterfaceCustomer.Properties;

namespace MiddleLayer
{
    public class Customer : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("CustomerName must be required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber must be required");
            }
            if (BillAmount == 0)
            {
                throw new Exception("BillAmount must be required");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address must be required");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Bill Date must be required");
            }
            
            
            
        }
    }
    public class CustomerBase :ICustomer
    {
        public string CustomerName { get; set; }
        public decimal BillAmount { get; set; }
        public string Address { get; set; }
        
        public DateTime BillDate { get; set; }
        public string PhoneNumber { get; set; }

        
        public virtual void Validate()
        {
            throw new Exception("Not implemented");
        }
    }
    public class Lead : CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("CustomerName must be required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber must be required");
            }
        }
    }
}