using System.Data.Entity;
using InterfaceCustomer;
using InterfaceDal;

namespace EfDal;

public class EfCustomerDal : EfDalAbstract<CustomerBase>
{
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerBase>().ToTable("tblCustomer");
    }

   
}