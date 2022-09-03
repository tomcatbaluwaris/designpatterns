using System;
using InterfaceCustomer;

namespace MiddleLayer
{

    //public abstract class Customer : ICustomer
    //{
    //    private Customer _oldValue;

    //    private string _CustomerCode = "";

    //    private string _CustomerName = "";


    //    public abstract void Validate();

    //    public string CustomerName
    //    {
    //        get
    //        {
    //            return _CustomerName;
    //        }
    //        set
    //        {
    //            _CustomerName = value;
    //        }
    //    }

    //    [Key]
    //    public string CustomerCode
    //    {
    //        get
    //        {
    //            return _CustomerCode;
    //        }
    //        set
    //        {
    //            _CustomerCode = value;
    //        }
    //    }


    //    private string _Type;


    //    public string CustomerType
    //    {
    //        get { return _Type; }
    //        set { _Type = value; }
    //    }



    //    public ICustomer Clone()
    //    {
    //        return (Customer)this.MemberwiseClone();
    //    }

    //}



    //public class SimpleCustomer : Customer
    //{
    //    public SimpleCustomer()
    //    {
    //        CustomerType = "0";
    //    }
    //    public override void Validate()
    //    {
    //        if (CustomerCode.Length == 0)
    //        {
    //            throw new Exception("Customer code not allowed");

    //        }
    //        if (CustomerName.Length == 0)
    //        {
    //            throw new Exception("Customer name not allowed");

    //        }
    //    }
    //}

    //public class CustomerSpecial : SimpleCustomer
    //{
    //    public CustomerSpecial()
    //    {
    //        CustomerType = "1";
    //    }
    //    public override void Validate()
    //    {
    //        this.Validate();
    //        if (CustomerName.Length > 8)
    //        {
    //            throw new Exception("Customer name not allowed");

    //        }
    //    }
    //}


    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> validation) : base(validation)
        {
            _validation = validation;
        }

        public Customer() 
        {
            
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
// public abstract class CustomerBase : ICustomer
// {
//     public IValidation<ICustomer> _validation = null;
//     public CustomerBase(IValidation<ICustomer> validation)
//     {
//         _validation = validation;
//     }
//
//
//
//     public string CustomerName { get; set; }
//     public decimal BillAmount { get; set; }
//     public string Address { get; set; }
//
//     public DateTime BillDate { get; set; }
//     public string PhoneNumber { get; set; }
//
//
//     public virtual void Validate()
//     {
//         _validation.Validate(this);
//     }
// }
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