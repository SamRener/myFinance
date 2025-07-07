namespace MyFinance.Domain;

public class Transaction : IModel
{
    public Transaction(int id, string? history, DateTime? date, double? amount, ChartOfAccount chartOfAccount)
    {
        Id = id;
        History = history;
        Date = date;
        Amount = amount;
        ChartOfAccount = chartOfAccount;
    }

    public int Id { get; set; }
    public string? History { get; init; }
    public DateTime? Date { get; init; }
    public double? Amount { get; init; }
    public ChartOfAccount ChartOfAccount { get; init; }
}
