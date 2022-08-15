using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCustomer
{
    public interface IValidation<TAnyType>
    {
        void Validate(TAnyType obj);
    }
}
