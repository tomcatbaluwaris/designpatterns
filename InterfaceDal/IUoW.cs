namespace InterfaceDal;

public interface IUoW
{
    void Commit();
    void Rollback();
}