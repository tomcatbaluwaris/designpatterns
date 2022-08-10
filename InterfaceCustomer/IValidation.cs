using InterfaceCustomer.Properties;

namespace InterfaceCustomer
{
    public interface IValidation<TAnyType>
    {
        void Validate(TAnyType obj);
    }
}