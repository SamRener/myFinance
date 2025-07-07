using MyFinance.Domain;

namespace MyFinance.Application.Requests;

public class InsertRequest<TModel, TDto>(ICrudService<TModel> service) : IInsertRequest<TDto> where TModel : IModel where TDto : IDto
{
    public void Handle(TDto data) => service.Insert((TModel)data.ToModel());
}