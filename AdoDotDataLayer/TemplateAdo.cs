using CommonDal;
using System.Data.SqlClient;
using InterfaceCustomer.Properties;

namespace AdoDotDataLayer
{
    public abstract class TemplateAdo<TAnyType> : AbstractDal<TAnyType>
    {
        private readonly string _connectionString;
        private SqlConnection _objConn = null;
        protected SqlCommand _objCommand;

        public TemplateAdo(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }
        
        //Design Pattern :- Template Pattern
        public void Execute(TAnyType obj)// Fixed Sequence
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }

        public override void Save()
        {
            foreach (var variableAnyType in AnyTypes)
            {
                Execute(variableAnyType);
            }
        }
        
        public void Open()
        {
            _objConn = new SqlConnection(ConnectionString);
            _objConn.Open();
            _objCommand = new SqlCommand();
            _objCommand.Connection = _objConn;
        }
        public void Close()
        {
            
        }

        public abstract void ExecuteCommand(TAnyType anyType);// Child classes override this method they needed



    }

    // I'm adding the ICostumer Interface and not the MiddleLayer
    public class CustomerDAL : TemplateAdo<ICustomer>
    {
        public CustomerDAL(string connectionString) : base(connectionString)
        {
            
        }

        public override void ExecuteCommand(ICustomer anyType)
        {
            _objCommand.CommandText = "insert into tblCustomer("+
            "CustomerName,"+
            "BillAmount, BillDate, PhoneNumber, Address,"+
            ")"+
            "values('"+anyType.CustomerName+""+anyType.BillAmount+""+anyType.BillDate+""+
            anyType.PhoneNumber+""+anyType.Address+""+
            ".)";
        }
    }
}