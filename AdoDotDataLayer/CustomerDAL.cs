using System.Data.SqlClient;
using InterfaceCustomer;

namespace AdoDotDataLayer;

public class CustomerDAL : TemplateAdo<ICustomer>
{
    public CustomerDAL(string connectionString) : base(connectionString)
    {
            
    }

    // public CustomerDAL() : base()
    // {
    //     throw new NotImplementedException();
    // }

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

    public override List<ICustomer> ExecuteCommand()
    {
        _objCommand.CommandText = $"select * from tblCustomer";
        SqlDataReader dr = null;
        dr = _objCommand.ExecuteReader();
        List<ICustomer> customers = new List<ICustomer>();
        while (dr.Read())
        {
            // Factory
        }

        return null;
    }
}