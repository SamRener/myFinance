using MyFinance.Domain;

namespace MyFinance.Application.Requests;

public class GetByIdRequest<TModel, TDto>(ICrudService<TModel> service) : IGetByIdRequest<TDto> where TModel : IModel where TDto : IDto
{
    public TDto Handle(int id) => (TDto)service.GetById(id).ToDto();
}