using MyFinance.Domain;

namespace MyFinance.Application;

public static class TransactionMapper
{
    public static TransactionDto ToDto(this Transaction model) => new TransactionDto(model.Id, model.History, model.Date, model.Amount, model.ChartOfAccount.Id);
    public static Transaction ToModel(this TransactionDto dto) => new Transaction(dto.Id, dto.History, dto.Date, dto.Amount, new ChartOfAccount(dto.ChartOfAccountId));
    public static IEnumerable<Transaction> ToModels(this IEnumerable<TransactionDto> entities) => entities.Select(x => x.ToModel());
    public static IEnumerable<TransactionDto> ToEntities(this IEnumerable<Transaction> models) => models.Select(x => x.ToDto());
}