namespace MyFinance.Application;

public class ChartOfAccountDto : IDto
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required char Type { get; set; }
}
