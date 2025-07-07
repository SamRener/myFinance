using MyFinance.Application;
using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Presentation.Apis;

public static class TransactionEndpoints
{
    public static void MapTransactions(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/transactions", ([FromServices] IGetRequest<TransactionDto> request) => request.Handle())
            .WithName("GetTransactions");
        
        builder.MapGet("/transactions/{id:int}", ([FromServices] IGetByIdRequest<TransactionDto> request, int id) => request.Handle(id))
            .WithName("GetTransaction");
        
        builder.MapPut("/transactions/{id:int}", ([FromServices] IUpdateRequest<TransactionDto> request, int id, [FromBody] TransactionDto transaction) => request.Handle(id, transaction))
            .WithName("UpdateTransaction");
        
        builder.MapPut("/transactions/", ([FromServices] IInsertRequest<TransactionDto> request, [FromBody] TransactionDto transaction) => request.Handle(transaction))
            .WithName("InsertTransaction");
        
        builder.MapDelete("/transactions/{id:int}", ([FromServices] IDeleteRequest<TransactionDto> request, int id) => request.Handle(id))
            .WithName("DeleteTransaction");
    }
}