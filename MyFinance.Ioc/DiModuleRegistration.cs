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
    public static void Registrate(this IServiceCollection services, IConfiguration configuration)
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
       services.AddDbContext<MyFinanceContext>();
       services.AddScoped<IRepository<TransactionEntity>, TransactionRepository>();
       services.AddScoped<IRepository<ChartOfAccountEntity>, Repository<ChartOfAccountEntity>>();
       
    }
}
