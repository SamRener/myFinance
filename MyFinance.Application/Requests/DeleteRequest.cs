using MyFinance.Domain;

namespace MyFinance.Application.Requests;

public class DeleteRequest<TModel, TDto>(ICrudService<TModel> service) : IDeleteRequest<TDto> where TModel : IModel where TDto : IDto
{
    public void Handle(int id) => service.Delete(id);
}