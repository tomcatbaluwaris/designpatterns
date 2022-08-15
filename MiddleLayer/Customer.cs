using System;
using InterfaceCustomer;

namespace MiddleLayer
{
    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> validation) : base(validation)
        {
            _validation = validation;
        }

        // public override void Validate()
        // {
        //     _validation.Validate(this);
        // }
        //     if (CustomerName.Length == 0)
        //     {
        //         throw new Exception("CustomerName must be required");
        //     }
        //     if (PhoneNumber.Length == 0)
        //     {
        //         throw new Exception("PhoneNumber must be required");
        //     }
        //     if (BillAmount == 0)
        //     {
        //         throw new Exception("BillAmount must be required");
        //     }
        //     if (Address.Length == 0)
        //     {
        //         throw new Exception("Address must be required");
        //     }
        //     if (BillDate >= DateTime.Now)
        //     {
        //         throw new Exception("Bill Date must be required");
        //     }
        //     
        //     

    }
}
public class CustomerBase : ICustomer
{
    public IValidation<ICustomer> _validation = null;
    public CustomerBase(IValidation<ICustomer> validation)
    {
        _validation = validation;
    }



    public string CustomerName { get; set; }
    public decimal BillAmount { get; set; }
    public string Address { get; set; }

    public DateTime BillDate { get; set; }
    public string PhoneNumber { get; set; }


    public virtual void Validate()
    {
        _validation.Validate(this);
    }
}
public class Lead : CustomerBase
{
    public IValidation<ICustomer> _validation = null;
    // public Lead(IValidation<ICustomer> validation)
    // {
    //  _validation  = validation;
    // }
    // public override void Validate()
    // {
    //     _validation.Validate(this);
    //     // if (CustomerName.Length == 0)
    //     // {
    //     //     throw new Exception("CustomerName must be required");
    //     // }
    //     // if (PhoneNumber.Length == 0)
    //     // {
    //     //     throw new Exception("PhoneNumber must be required");
    //     // }
    // }


    public Lead(IValidation<ICustomer> validation) : base(validation)
    {
        _validation = validation;
    }
}

// }