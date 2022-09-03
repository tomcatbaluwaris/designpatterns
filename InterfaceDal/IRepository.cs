using System.Transactions;

namespace InterfaceDal
{
    //Design pattern :- Repository pattern
    public interface IRepository<TAnyType>
    {
        void SetUnitOfWork(IUoW uoW);
        void Add(TAnyType obj); //Inmemory addition
        void Update(TAnyType obj); // Inmemory updation
        List<TAnyType> Search();
        void Save(); // Physical commit
    }
}