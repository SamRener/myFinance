namespace MyFinance.Application;

public class TransactionDto : IDto
{
    public TransactionDto(int id, string? history, DateTime? date, double? amount, int chartOfAccountId)
    {
        Id = id;
        History = history;
        Date = date;
        Amount = amount;
        ChartOfAccountId = chartOfAccountId;
    }

    public int Id { get; init; }
    public string? History { get; init; }
    public DateTime? Date { get; init; }
    public double? Amount { get; init; }
    public int ChartOfAccountId { get; init; }
}
