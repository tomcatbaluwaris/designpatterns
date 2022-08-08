using System;
using System.Collections.Generic;
using System.Dynamic;
using InterfaceCustomer.Properties;
using Microsoft.Practices.Unity;
using MiddleLayer;

namespace Factory
{
    public static class FactoryCustomer // Simple Factory Pattern
    {
        private static IUnityContainer _unityContainer;
        private static Dictionary<string, ICustomer> customers = new Dictionary<string, ICustomer>();
        
        // private static Lazy<Dictionary<string, CustomerBase>> customers = new Lazy<Dictionary<string, CustomerBase>>();

        //Design Pattern RIP Pattern => Replace if with polymorphismn
        static FactoryCustomer()
        {
        }
        
        // static FactoryCustomer()
        // {
        //     customers.Value.Add("Lead", new Lead());
        //     customers.Value.Add("Customer", new Customer());
        //  
        // }
        public static ICustomer Create(string typeCustomer)
        {
            if (_unityContainer == null)
            {
                _unityContainer = new UnityContainer();
                _unityContainer.RegisterType<ICustomer, Customer>("Customer");
                _unityContainer.RegisterType<ICustomer, Lead>("Lead");
                // customers.Add("Lead", new Lead());
                // customers.Add("Customer", new Customer());
            
            }

            return _unityContainer.Resolve<ICustomer>(typeCustomer);
        }
    }
}