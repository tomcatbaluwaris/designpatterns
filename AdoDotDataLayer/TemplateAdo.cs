using CommonDal;
using System.Data.SqlClient;

namespace AdoDotDataLayer
{
    public abstract class TemplateAdo<TAnyType> : AbstractDal<TAnyType>
    {
        private readonly string _connectionString;
        private SqlConnection _objConn = null;
        private SqlCommand _objCommand;

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
}