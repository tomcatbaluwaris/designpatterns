using System;
using System.Dynamic;
using MiddleLayer;

namespace Factory
{
    public static class FactoryCustomer
    {
        public static CustomerBase Create(string typeCustomer)
        {
            if (typeCustomer == "Customer")
            {
                return new Customer();
            }

            return new Lead();
        }
    }
}