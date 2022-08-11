namespace InterfaceDal
{
    //Design pattern :- Repository pattern
    public interface IDal<TAnyType>
    {
        void Add(TAnyType obj); //Inmemory addition
        void Update(TAnyType obj); // Inmemory updation
        List<TAnyType> Search();
        void Save(); // Physical commit
    }
}