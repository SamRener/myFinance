using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyFinance.Infra;

public class MyFinanceContext(/* IConfiguration configuration */) : DbContext
{
    public DbSet<ChartOfAccountEntity> ChartOfAccounts { get; set; }
    public DbSet<TransactionEntity> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyFinance;User Id=dbuser;Password=dbuser;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}