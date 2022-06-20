using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeBase.Migrations
{
    public partial class PopulateFrameworks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Frameworks (Plataforma, Apelido, Descricao, Versao) VALUES (01, 'NC01', '.NET Core', '1.0')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Apelido WHERE Plataforma = 'NC01'");

        }
    }
}
