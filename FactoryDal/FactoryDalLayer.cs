using EfDal;
using InterfaceCustomer;
using InterfaceDal;
using Microsoft.Practices.Unity;
using MiddleLayer;

namespace FactoryDal;

public class FactoryDalLayer<TAnyType>
{
    private static IUnityContainer _unityContainerObjects;
    private static Dictionary<string, ICustomer> customers = new Dictionary<string, ICustomer>();

    // private static Lazy<Dictionary<string, CustomerBase>> customers = new Lazy<Dictionary<string, CustomerBase>>();

    //Design Pattern RIP Pattern => Replace if with polymorphismn
    static FactoryDalLayer()
    {
    }

    // static FactoryCustomer()
    // {
    //     customers.Value.Add("Lead", new Lead());
    //     customers.Value.Add("Customer", new Customer());
    // }
    
    //if we change the type from a normal entity to a generic one. The class FactoryCustomer itself must
    //be also marked as generic
    public static TAnyType Create(string typeCustomer)
    {
        if (_unityContainerObjects == null)
        {
            _unityContainerObjects = new UnityContainer();
            // _unityContainerObjects.RegisterType<ICustomer, Customer>("Customer",
            //     new InjectionConstructor(new CustomerValidationAll()));
            // _unityContainerObjects.RegisterType<ICustomer, Lead>("Lead",
            //     new InjectionConstructor(new LeadValidation()));
            //Todo wieder einfügen
            //_unityContainerObjects.RegisterType<IDal<ICustomer>, CustomerDAL>("ADODal");
            _unityContainerObjects.RegisterType<IRepository<Customer>, EfRepository<Customer>>("EfDal");
            // _unityContainerObjects.RegisterType<IUoW, AdoUoW>("AdoUoW");
            _unityContainerObjects.RegisterType<IUoW, EfUoW>("EUoW");
            // _unityContainerObjects.RegisterType<IDal<ICustomer>, >("Lead", new InjectionConstructor(new LeadValidation()));
            // customers.Add("Lead", new Lead());
            // customers.Add("Customer", new Customer());
        }

        return _unityContainerObjects.Resolve<TAnyType>(typeCustomer, overrides: new ResolverOverride[]
        {
            new ParameterOverride("ConnectionString",
                $"Server=DESKTOP-TJ8J7V7;Database=MangoProductAPI;Trusted_Connection=True;MultipleActiveResultSets=True")
        });


    }
}