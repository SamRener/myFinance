using MyFinance.Application;
using Microsoft.AspNetCore.Mvc;

namespace MyFinance.Presentation.Apis;

public static class ChartOfAccountEndpoints
{
    public static void MapChartOfAccounts(this IEndpointRouteBuilder builder)
    {
        builder.MapGet("/api/chartOfAccount", ([FromServices] IGetRequest<ChartOfAccountDto> request) => request.Handle())
            .WithName("GetChartOfAccounts");
        
        builder.MapGet("/api/chartOfAccount/{id:int}", ([FromServices] IGetByIdRequest<ChartOfAccountDto> request, int id) => request.Handle(id))
            .WithName("GetChartOfAccount");
        
        builder.MapPut("/api/chartOfAccount/{id:int}", ([FromServices] IUpdateRequest<ChartOfAccountDto> request, int id, [FromBody] ChartOfAccountDto transaction) => request.Handle(id, transaction))
            .WithName("UpdateChartOfAccount");
        
        builder.MapPut("/api/chartOfAccount/", ([FromServices] IInsertRequest<ChartOfAccountDto> request, [FromBody] ChartOfAccountDto transaction) => request.Handle(transaction))
            .WithName("InsertChartOfAccount");
        
        builder.MapDelete("/api/chartOfAccount/{id:int}", ([FromServices] IDeleteRequest<ChartOfAccountDto> request, int id) => request.Handle(id))
            .WithName("DeleteChartOfAccount");
    }
}