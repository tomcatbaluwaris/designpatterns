using System.Data;
using InterfaceDal;

namespace AdoDotDataLayer;

public class AdoNet<TAnyType> : IDal<TAnyType>
{
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