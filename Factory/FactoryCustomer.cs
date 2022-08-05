using System;
using System.Collections.Generic;
using System.Dynamic;
using MiddleLayer;

namespace Factory
{
    public static class FactoryCustomer // Simple Factory Pattern
    {
        private static Dictionary<string, CustomerBase> customers = new Dictionary<string, CustomerBase>();

        //Design Pattern RIP Pattern => Replace if with polymorphismn
        static FactoryCustomer()
        {
            customers.Add("Customer",new Customer());
            customers.Add("Lead",new Lead());
        }
        public static CustomerBase Create(string typeCustomer)
        {
            var customerBase = customers[typeCustomer];
            return customerBase;

        }
    }
}