using InterfaceCustomer;

namespace AdoDotDataLayer;

public class CustomerDAL : TemplateAdo<ICustomer>
{
    public CustomerDAL(string connectionString) : base(connectionString)
    {
            
    }

    public override void ExecuteCommand(ICustomer anyType)
    {
        _objCommand.CommandText = "insert into tblCustomer("+
                                  "CustomerName,"+
                                  "BillAmount, BillDate, PhoneNumber, Address"+
                                  ")"+
                                  "values('"+anyType.CustomerName+"', "+anyType.BillAmount+",'"+anyType.BillDate
                                  +"','"+
                                  anyType.PhoneNumber+"', '"+anyType.Address+"'"+
                                  ")";
        _objCommand.ExecuteNonQuery();
    }
}