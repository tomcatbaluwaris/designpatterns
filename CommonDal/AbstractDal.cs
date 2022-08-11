namespace CommonDal
{
    public class AbstractDal<TAnyType> : InterfaceDal.IDal<TAnyType>
    {
        protected string ConnectionString = "";

        public AbstractDal(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected List<TAnyType> AnyTypes = new List<TAnyType>();
        public void Add(TAnyType obj)
        {
            throw new NotImplementedException();
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