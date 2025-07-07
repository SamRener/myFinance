namespace MyFinance.Domain;

public class ChartOfAccount(int Id) : IModel
{
    public ChartOfAccount(int Id, string name, ChartOfAccountsType type) : this(Id)
    {
        Name = name;
        Type = type;
    }

    public int Id { get; set; } = Id;
    public string Name { get; set; }
public ChartOfAccountsType Type { get; set; }
}

public enum ChartOfAccountsType
{
    Income = 'R',
    Expenses = 'D'
}
