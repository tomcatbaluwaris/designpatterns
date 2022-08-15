using System;
using InterfaceCustomer;


namespace ValidationAlgorithms
{
    //This is the strategy-pattern.Helps to choose algorithmens dynamically(on runtime)
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("CustomerName must be required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber must be required");
            }
            if (obj.BillAmount == 0)
            {
                throw new Exception("BillAmount must be required");
            }
            if (obj.Address.Length == 0)

            {
                throw new Exception("Address must be required");
            }
            if (obj.BillDate >= DateTime.Now)
            {
                throw new Exception("Bill Date must be required");
            }

        }
    }
    public class LeadValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (obj.CustomerName.Length == 0)
            {
                throw new Exception("CustomerName must be required");
            }
            if (obj.PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber must be required");
            }

        }
    }
}