using MyFinance.Domain;

namespace MyFinance.Application;

public static class ModelMapper
{
    public static IDto ToDto(this IModel model) => model switch
        {
            ChartOfAccount chartOfAccount => chartOfAccount.ToDto(),
            Transaction transaction => transaction.ToDto(),
            _ => throw new Exception("Unknown Model")
        };
    
    public static IModel ToModel(this IDto dto) => dto switch
    {
        ChartOfAccountDto chartOfAccount => chartOfAccount.ToModel(),
        TransactionDto transaction => transaction.ToModel(),
        _ => throw new Exception("Unknown Dto")
    };

    public static IEnumerable<IModel> ToModels(this IEnumerable<IDto> entities)
    {
        var dtoType = entities.GetType().GetGenericArguments()[0];
        
        if(dtoType == typeof(ChartOfAccountDto))
            return ((IEnumerable<ChartOfAccountDto>)entities).ToModels();
        
        if(dtoType == typeof(TransactionDto))
            return ((IEnumerable<TransactionDto>)entities).ToModels();

        throw new Exception("Unknown Dto");
    }
    
    public static IEnumerable<IDto> ToEntities(this IEnumerable<IModel> models)
    {
        var modelsType = models.GetType().GetGenericArguments()[0];
        
        if(modelsType == typeof(ChartOfAccount))
            return ((IEnumerable<ChartOfAccount>)models).ToEntities();
        
        if(modelsType == typeof(Transaction))
            return ((IEnumerable<Transaction>)models).ToEntities();

        throw new Exception("Unknown Model");
    }
}