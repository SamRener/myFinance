namespace MyFinance.Domain;

public interface ICrudService<T> where T : IModel
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Update(int id, T transaction);
    void Insert(T transaction);
    void Delete(int id);
}