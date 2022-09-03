using System.Data;
using System.Data.Entity;
using InterfaceDal;
using MiddleLayer;

namespace EfDal;

public class EfUoW : DbContext, IUoW
{
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("tblCustomer");
    }

    public EfUoW():base($"Server=DESKTOP-TJ8J7V7;Database=CustomerDB;Trusted_Connection=True;MultipleActiveResultSets=True")
    {
        
    }
    public void Commit()
    {
        SaveChanges();
    }

    public void Rollback() //Adapter
    {
        Dispose();
    }
}