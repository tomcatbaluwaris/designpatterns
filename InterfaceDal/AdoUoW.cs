using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;

namespace InterfaceDal;

public class AdoUoW : IUoW
{
    public SqlConnection Connection { get; set; }
    public SqlTransaction Transaction { get; set; }

    public AdoUoW()
    {
        Connection = new SqlConnection($"Server=DESKTOP-TJ8J7V7;Database=CustomerDB;Trusted_Connection=True;MultipleActiveResultSets=True");
        Connection.Open();
        Transaction = Connection.BeginTransaction();
    }
    public void Commit()
    {
        Transaction.Commit();
        Connection.Close();
    }

    public void Rollback()
    {
        Transaction.Rollback();
        Connection.Close();
    }
}