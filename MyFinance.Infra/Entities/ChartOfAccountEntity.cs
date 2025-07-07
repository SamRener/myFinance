using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinance.Infra;

public record ChartOfAccountEntity(): IEntity
{
    public ChartOfAccountEntity(int id, string name, char type): this()
    {
        Id = id;
        Name = name;
        Type = type;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }
    public string Name { get; init; }
    public char Type { get; init; }
}