namespace InterfaceCustomer
{
    public class CustomerBase : ICustomer
    {
        public IValidation<ICustomer> _validation = null;
        public CustomerBase(IValidation<ICustomer> validation)
        {
            _validation = validation;
        }


        public int Id { get; set; }
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
}