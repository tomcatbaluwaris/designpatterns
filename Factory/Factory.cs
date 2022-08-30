//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Factory
//{
//    internal class FactoryCustomer
//    {
//    }
//}

using System;
using System.Collections.Generic;
using System.Dynamic;
using AdoDotDataLayer;
using InterfaceCustomer;
using InterfaceDal;
using Microsoft.Practices.Unity;
using MiddleLayer;
using ValidationAlgorithms;

namespace FactoryCustomer
{
    public static class Factory<TAnyType> // Simple Factory Pattern
    {
        private static IUnityContainer _unityContainerObjects;
        private static Dictionary<string, ICustomer> customers = new Dictionary<string, ICustomer>();

        // private static Lazy<Dictionary<string, CustomerBase>> customers = new Lazy<Dictionary<string, CustomerBase>>();

        //Design Pattern RIP Pattern => Replace if with polymorphismn
        static Factory()
        {
        }

        // static FactoryCustomer()
        // {
        //     customers.Value.Add("Lead", new Lead());
        //     customers.Value.Add("Customer", new Customer());
        //  
        // }
        //if we change the type from a normal entity to a generic one. The class FactoryCustomer itself must
        //be also marked as generic
        public static TAnyType Create(string typeCustomer)
        {
            if (_unityContainerObjects == null)
            {
                _unityContainerObjects = new UnityContainer();
                _unityContainerObjects.RegisterType<CustomerBase, Customer>("Customer", new InjectionConstructor(new CustomerValidationAll()));
                _unityContainerObjects.RegisterType<CustomerBase, Lead>("Lead", new InjectionConstructor(new LeadValidation()));
                //_unityContainerObjects.RegisterType<IDal<ICustomer>, CustomerDAL>("ADODal");
                // _unityContainerObjects.RegisterType<IDal<ICustomer>, >("Lead", new InjectionConstructor(new LeadValidation()));
                // customers.Add("Lead", new Lead());
                // customers.Add("Customer", new Customer());

            }

            return _unityContainerObjects.Resolve<TAnyType>(typeCustomer,overrides: new ResolverOverride[]
            {
                new ParameterOverride("ConnectionString",$"Server=DESKTOP-TJ8J7V7;Database=CustomerDB;Trusted_Connection=True;MultipleActiveResultSets=True")
            });
            
            
            
        }
    }
}