using MyFinance.Domain;

namespace MyFinance.Application.Requests;

public class GetRequest<TModel, TDto>(ICrudService<TModel> service) : IGetRequest<TDto> where TModel : IModel where TDto : IDto
{
    public IEnumerable<TDto> Handle() => service.GetAll().Select(x => (TDto)x.ToDto());
}