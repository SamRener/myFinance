using MyFinance.Domain;

namespace MyFinance.Application.Requests;

public class UpdateRequest<TModel, TDto>(ICrudService<TModel> service) : IUpdateRequest<TDto> where TModel : IModel where TDto : IDto
{
    public void Handle(int id, TDto data) => service.Update(id, (TModel)data.ToModel());
}