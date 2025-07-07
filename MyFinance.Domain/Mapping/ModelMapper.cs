using MyFinance.Infra;

namespace MyFinance.Domain.Mapping;

public static class ModelMapper
{
    public static IEntity ToEntity(this IModel model) => model switch
        {
            ChartOfAccount chartOfAccount => chartOfAccount.ToEntity(),
            Transaction transaction => transaction.ToEntity(),
            _ => throw new Exception("Unknown Model")
        };
    
    public static IModel ToModel(this IEntity entity) => entity switch
    {
        ChartOfAccountEntity chartOfAccount => chartOfAccount.ToModel(),
        TransactionEntity transaction => transaction.ToModel(),
        _ => throw new Exception("Unknown Entity")
    };

    public static IEnumerable<IModel> ToModels(this IEnumerable<IEntity> entities)
    {
        var entityType = entities.GetType().GetGenericArguments()[0];
        
        if(entityType == typeof(ChartOfAccountEntity))
            return ((IEnumerable<ChartOfAccountEntity>)entities).ToModels();
        
        if(entityType == typeof(TransactionEntity))
            return ((IEnumerable<TransactionEntity>)entities).ToModels();

        throw new Exception("Unknown Entity");
    }
    
    public static IEnumerable<IEntity> ToEntities(this IEnumerable<IModel> models)
    {
        var modelsType = models.GetType().GetGenericArguments()[0];
        
        if(modelsType == typeof(ChartOfAccount))
            return ((IEnumerable<ChartOfAccount>)models).ToEntities();
        
        if(modelsType == typeof(Transaction))
            return ((IEnumerable<Transaction>)models).ToEntities();

        throw new Exception("Unknown Model");
    }
}