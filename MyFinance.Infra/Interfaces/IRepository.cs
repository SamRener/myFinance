namespace MyFinance.Infra;

public interface IRepository<T> where T : IEntity
{
    T GetById(int id);

    List<T> GetAll();
    
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
}