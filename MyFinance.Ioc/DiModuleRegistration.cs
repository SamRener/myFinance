using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFinance.Application;
using MyFinance.Application.Requests;
using MyFinance.Domain;
using MyFinance.Domain.Services;
using MyFinance.Infra;
using MyFinance.Infra.Repositories;

namespace MyFinance.Ioc;

public static class DiModuleRegistration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Application
        services.AddScoped<IDeleteRequest<TransactionDto>, DeleteRequest<Transaction, TransactionDto>>();
        services.AddScoped<IGetByIdRequest<TransactionDto>, GetByIdRequest<Transaction, TransactionDto>>();
        services.AddScoped<IGetRequest<TransactionDto>, GetRequest<Transaction, TransactionDto>>();
        services.AddScoped<IInsertRequest<TransactionDto>, InsertRequest<Transaction, TransactionDto>>();
        services.AddScoped<IUpdateRequest<TransactionDto>, UpdateRequest<Transaction, TransactionDto>>();

        services.AddScoped<IDeleteRequest<ChartOfAccountDto>, DeleteRequest<ChartOfAccount, ChartOfAccountDto>>();
        services.AddScoped<IGetByIdRequest<ChartOfAccountDto>, GetByIdRequest<ChartOfAccount, ChartOfAccountDto>>();
        services.AddScoped<IGetRequest<ChartOfAccountDto>, GetRequest<ChartOfAccount, ChartOfAccountDto>>();
        services.AddScoped<IInsertRequest<ChartOfAccountDto>, InsertRequest<ChartOfAccount, ChartOfAccountDto>>();
        services.AddScoped<IUpdateRequest<ChartOfAccountDto>, UpdateRequest<ChartOfAccount, ChartOfAccountDto>>();

        // Domain
        services.AddScoped<ICrudService<Transaction>, CrudService<Transaction, TransactionEntity>>();
        services.AddScoped<ICrudService<ChartOfAccount>, CrudService<ChartOfAccount, ChartOfAccountEntity>>();

        //Infra

        if (!string.IsNullOrEmpty(configuration.GetConnectionString("SqlServer")))
            services.AddDbContext<MyFinanceContext>();
        else
            services.AddDbContext<MyFinanceContext, SqliteMyFinanceContext>();

        services.AddScoped<IRepository<TransactionEntity>, TransactionRepository>();
        services.AddScoped<IRepository<ChartOfAccountEntity>, Repository<ChartOfAccountEntity>>();

    }

    public static void EnsureDatabase(this IServiceProvider serviceProvider)
    {
        var ctx =  serviceProvider.CreateScope().ServiceProvider.GetService<MyFinanceContext>();
        
        var migrations = ctx.Database.GetPendingMigrations().ToList();
        
        if (migrations.Count <= 0) return;

        Console.WriteLine("As seguintes migrations foram encontradas e serão aplicadas: " + string.Join(", ", migrations));
        ctx.Database.Migrate();
    }
}
