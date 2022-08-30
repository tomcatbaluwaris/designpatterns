using InterfaceCustomer;

namespace FactoryLayer;

public class FactoryCustomer
{
    List<ICustomer> custs = new List<ICustomer>();
    public FactoryCustomer()
    {
        // custs.Add(new SimpleCustomer());
        // custs.Add(new CustomerSpecial());
    }
    // public ICustomer Create(int type)
    // {
    //     return  custs[type].Clone();
    //         
    // }
        
}
