using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyFinance.Infra;

public class SqliteMyFinanceContext(/*IConfiguration configuration*/) : MyFinanceContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=MyFinance.db");
}