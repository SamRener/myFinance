using MyFinance.Infra;

namespace MyFinance.Domain.Mapping;

public static class TransactionMapper
{
    public static TransactionEntity ToEntity(this Transaction model) => new TransactionEntity(model.Id, model.History, model.Date, model.Amount, model.ChartOfAccount.ToEntity());
    public static Transaction ToModel(this TransactionEntity entity) => new Transaction(entity.Id, entity.History, entity.Date, entity.Amount, entity.ChartOfAccount.ToModel());
    public static IEnumerable<Transaction> ToModels(this IEnumerable<TransactionEntity> entities) => entities.Select(x => x.ToModel());
    public static IEnumerable<TransactionEntity> ToEntities(this IEnumerable<Transaction> models) => models.Select(x => x.ToEntity());
}