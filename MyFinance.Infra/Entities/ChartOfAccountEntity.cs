using System.ComponentModel.DataAnnotations;

namespace MyFinance.Infra;

public record ChartOfAccountEntity: IEntity
{

    public ChartOfAccountEntity()
    {
        
    }

    public ChartOfAccountEntity(int id, string name, char type)
    {
        Id = id;
        Name = name;
        Type = type;
    }

    [Key]
    public int Id { get; init; }
    public string Name { get; init; }
    public char Type { get; init; }
}