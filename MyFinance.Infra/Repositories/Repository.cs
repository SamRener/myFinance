namespace MyFinance.Infra.Repositories;

public class Repository<T>(MyFinanceContext ctx) : IRepository<T> where T : class, IEntity
{
    public virtual T GetById(int id) => ctx.Set<T>().Find(id)!;

    public virtual List<T> GetAll() => ctx.Set<T>().ToList();

    public virtual void Insert(T entity)
    {
        ctx.Set<T>().Add(entity);
        ctx.SaveChanges();
    }

    public virtual void Update(T entity)
    {
        ctx.Set<T>().Attach(entity);
        ctx.Set<T>().Update(entity);
        ctx.SaveChanges();
    }

    public virtual void Delete(T entity)
    {
        ctx.Set<T>().Attach(entity);
        ctx.Set<T>().Remove(entity);
        ctx.SaveChanges();
    }
}