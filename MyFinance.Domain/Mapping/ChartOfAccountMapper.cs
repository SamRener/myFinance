using MyFinance.Infra;

namespace MyFinance.Domain.Mapping;

public static class ChartOfAccountMapper
{
    public static ChartOfAccountEntity ToEntity(this ChartOfAccount model) => new ChartOfAccountEntity(model.Id, model.Name, (char)model.Type);
    public static ChartOfAccount ToModel(this ChartOfAccountEntity entity) => new ChartOfAccount(entity.Id, entity.Name, (ChartOfAccountsType)entity.Type);
    public static IEnumerable<ChartOfAccount> ToModels(this IEnumerable<ChartOfAccountEntity> entities) => entities.Select(x => x.ToModel());
    public static IEnumerable<ChartOfAccountEntity> ToEntities(this IEnumerable<ChartOfAccount> models) => models.Select(x => x.ToEntity());
}