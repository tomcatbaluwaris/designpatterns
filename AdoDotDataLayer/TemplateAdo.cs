using CommonDal;
using System.Data.SqlClient;


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
        
        //Design Pattern :- Template Pattern => Fixed Sequence, but the child classes do have the liberty to override the methods if needed
        public void Execute(TAnyType obj)// Fixed Sequence
        {
            Open();
            ExecuteCommand(obj);
            Close();
        }
        
        //Design Pattern :- Template Pattern => Fixed Sequence, but the child classes do have the liberty to override the methods if needed
        public List<TAnyType> Execute()// Fixed Sequence
        {
            List<TAnyType> objTypes = null;
            Open();
            objTypes = ExecuteCommand();
            Close();
            return objTypes;
        }

        public override void Save()
        {
            foreach (var variableAnyType in AnyTypes)
            {
                Execute(variableAnyType);
            }
        }
        
        //Design Pattern :- Template Pattern
        public void Open()
        {
            _objConn = new SqlConnection(ConnectionString);
            _objConn.Open();
            _objCommand = new SqlCommand();
            _objCommand.Connection = _objConn;
        }
        public void Close()
        {
            _objConn.Close();
        }

        public abstract void ExecuteCommand(TAnyType anyType);// Child classes override this method they needed
        public abstract List<TAnyType> ExecuteCommand(
            );// Child classes override this method they needed



    }

    // I'm adding the ICostumer Interface and not the MiddleLayer
}