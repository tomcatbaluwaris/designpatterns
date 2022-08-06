using System;
using System.Collections.Generic;
using System.Dynamic;
using MiddleLayer;

namespace Factory
{
    public static class FactoryCustomer // Simple Factory Pattern
    {
        private static Dictionary<string, CustomerBase> customers = new Dictionary<string, CustomerBase>();
        
        // private static Lazy<Dictionary<string, CustomerBase>> customers = new Lazy<Dictionary<string, CustomerBase>>();

        //Design Pattern RIP Pattern => Replace if with polymorphismn
        static FactoryCustomer()
        {
             
             if (customers.Count == 0) {
            customers.Add("Lead", new Lead());
            customers.Add("Customer", new Customer());
            }
        }
        
        // static FactoryCustomer()
        // {
        //     customers.Value.Add("Lead", new Lead());
        //     customers.Value.Add("Customer", new Customer());
        //  
        // }
        public static CustomerBase Create(string typeCustomer)
        {
            var customerBase = customers[typeCustomer];
            return customerBase;

        }
    }
}