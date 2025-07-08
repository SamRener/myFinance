using MyFinance.Ioc;
using MyFinance.Presentation.Apis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureServices(builder.Configuration);

builder.Services.AddCors((options) =>
{
    options.AddPolicy(name: "DefaultPolicy", policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyMethod();
        policy.AllowAnyHeader();
    });
});

var app = builder.Build();

app.Services.EnsureDatabase();

app.UseStaticFiles();

app.MapFallbackToFile("index.html");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("DefaultPolicy");
app.MapTransactions();
app.MapChartOfAccounts();

app.Run();

