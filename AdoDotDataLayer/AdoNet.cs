using System.Data;
using InterfaceDal;

namespace AdoDotDataLayer;

public class AdoNet<TAnyType> : IRepository<TAnyType>
{
    public void SetUnitOfWork(IUoW uoW)
    {
        throw new NotImplementedException();
    }

    public void Add(TAnyType obj)
    {
        throw new NotImplementedException();
    }

    public void Update(TAnyType obj)
    {
        throw new NotImplementedException();
    }

    public List<TAnyType> Search()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}