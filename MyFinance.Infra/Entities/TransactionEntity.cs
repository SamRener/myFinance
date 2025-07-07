using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Infra;

public record TransactionEntity() : IEntity
{
    public TransactionEntity(int id, string? history, DateTime? date, double? amount, ChartOfAccountEntity chartOfAccount) : this()
    {
        Id = id;
        History = history;
        Date = date;
        Amount = amount;
        ChartOfAccount = chartOfAccount;
        ChartOfAccountId = chartOfAccount.Id;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string? History { get; init; }
    public DateTime? Date { get; init; }
    public double? Amount { get; init; }
    public int ChartOfAccountId { get; init; }
    public virtual ChartOfAccountEntity ChartOfAccount { get; init; }
}