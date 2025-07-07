using System.ComponentModel.DataAnnotations;

namespace MyFinance.Infra;

public record TransactionEntity : IEntity
{
    public TransactionEntity()
    {
        
    }
    public TransactionEntity(int id, string? history, DateTime? date, double? amount, ChartOfAccountEntity chartOfAccount)
    {
        Id = id;
        History = history;
        Date = date;
        Amount = amount;
        ChartOfAccount = chartOfAccount;
        ChartOfAccountId = chartOfAccount.Id;
    }

    [Key]
    public int Id { get; init; }
    public string? History { get; init; }
    public DateTime? Date { get; init; }
    public double? Amount { get; init; }
    public int ChartOfAccountId { get; init; }
    public virtual ChartOfAccountEntity ChartOfAccount { get; init; }
}