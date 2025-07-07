using MyFinance.Domain;

namespace MyFinance.Application;

public static class ChartOfAccountMapper
{
    public static ChartOfAccountDto ToDto(this ChartOfAccount model) => new() { Id = model.Id, Type = (char)model.Type, Name = model.Name};
    public static ChartOfAccount ToModel(this ChartOfAccountDto dto) => new(dto.Id, dto.Name, (ChartOfAccountsType)dto.Type);
    public static IEnumerable<ChartOfAccount> ToModels(this IEnumerable<ChartOfAccountDto> dtos) => dtos.Select(x => x.ToModel());
    public static IEnumerable<ChartOfAccountDto> ToDtos(this IEnumerable<ChartOfAccount> models) => models.Select(x => x.ToDto());
}