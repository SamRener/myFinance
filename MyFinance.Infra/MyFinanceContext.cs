using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyFinance.Infra;

public class MyFinanceContext(IConfiguration configuration) : DbContext
{
    public DbSet<ChartOfAccountEntity> ChartOfAccounts { get; set; }
    public DbSet<TransactionEntity> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         var connString = configuration.GetConnectionString("SqlServer");

         if (!string.IsNullOrEmpty(connString))
         {
            optionsBuilder.UseSqlServer(connString);
         }
    }
}