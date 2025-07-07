using Microsoft.EntityFrameworkCore;

namespace MyFinance.Infra.Repositories;

public class TransactionRepository(MyFinanceContext ctx) : Repository<TransactionEntity>(ctx)
{
    public override List<TransactionEntity> GetAll() => ctx.Transactions.Include(x => x.ChartOfAccount).ToList();
}