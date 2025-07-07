using MyFinance.Domain.Mapping;
using MyFinance.Infra;

namespace MyFinance.Domain.Services;

public class CrudService<TModel, TEntity>(IRepository<TEntity> repository) : ICrudService<TModel> where TModel : IModel where TEntity : IEntity
{
    public IEnumerable<TModel> GetAll() =>  repository.GetAll().Select(x => (TModel)x.ToModel());
    public TModel GetById(int id) => (TModel)repository.GetById(id).ToModel();

    public void Update(int id, TModel model)
    {
        model.Id = id;
        repository.Update((TEntity)model.ToEntity());
    }

    public void Insert(TModel model) => repository.Insert((TEntity)model.ToEntity());

    public void Delete(int id)
    {
        var entity  = repository.GetById(id);
        repository.Delete(entity);
    }
}