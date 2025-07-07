using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFinance.Infra.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("ChartOfAccounts", ["Name","Type"], ["Combustível", "D"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Alimentação", "D"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Saúde", "D"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Manutenção Carro", "D"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Viagens", "D"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Salário", "R"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Juros Recebidos", "R"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Créditos de Dividendos", "R"]);
            migrationBuilder.InsertData("ChartOfAccounts", ["Name", "Type"], ["Restituição de IR", "R"]);
            
            migrationBuilder.InsertData("Transactions", ["History", "Date", "Amount", "ChartOfAccountId"], ["Combustível Blazer", DateTime.Now, 489, 1]);
            migrationBuilder.InsertData("Transactions", ["History", "Date", "Amount", "ChartOfAccountId"], ["Almoço de Domingo", "2025-05-18 12:00", 150, 2]);
            migrationBuilder.InsertData("Transactions", ["History", "Date", "Amount", "ChartOfAccountId"], ["Peças da Blazer", "2025-05-10 03:00", 18000, 4]);
            migrationBuilder.InsertData("Transactions", ["History", "Date", "Amount", "ChartOfAccountId"], ["Salário", "2025-05-12 10:00", 10000, 6]);
            migrationBuilder.InsertData("Transactions", ["History", "Date", "Amount", "ChartOfAccountId"], ["ITAUSA", "2025-05-14 10:00", 678, 8]);
                        
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "ChartOfAccounts");
        }
    }
}
