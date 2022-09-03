using InterfaceDal;

namespace CommonDal
{
    public abstract class Repository<TAnyType> : InterfaceDal.IRepository<TAnyType>
    {
        protected string ConnectionString = $"Server=DESKTOP-TJ8J7V7;Database=CustomerDB;Trusted_Connection=True;MultipleActiveResultSets=True";

        public Repository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected List<TAnyType> AnyTypes = new List<TAnyType>();
        public abstract void SetUnitOfWork(IUoW uoW);
       

        public void Add(TAnyType obj)
        {
            AnyTypes.Add(obj);
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public List<TAnyType> Search()
        {
            throw new NotImplementedException();
        }

        public void Update(TAnyType obj)
        {
            throw new NotImplementedException();
        }
    }
}