using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeBase.Migrations
{
    public partial class ProvraPopulateErros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Erros (Nome, Codigo, FrameworkId) VALUES ('Erro: 101', 'Código: 560', 45)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Erros WHERE FrameworkId = 45");
        }
    }
}
