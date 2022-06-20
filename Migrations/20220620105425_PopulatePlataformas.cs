using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KnowledgeBase.Migrations
{
    public partial class PopulatePlataformas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC1', '.NET Core', '1.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas(Apelido, Descricao, Versao) VALUES('NC11', '.NET Core', '1.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC2', '.NET Core', '2.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC21', '.NET Core', '2.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC22', '.NET Core', '2.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC3', '.NET Core', '3.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC31', '.NET Core', '3.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC5', '.NET Core', '5.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC6', '.NET Core', '6.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NC7', '.NET Core', '7.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF1', '.NET Framework', '1.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF11', '.NET Framework', '1.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF2', '.NET Framework', '2.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF3', '.NET Framework', '3.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF35', '.NET Framework', '3.5')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF42', '.NET Framework', '4.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF45', '.NET Framework', '4.5')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF451', '.NET Framework', '4.5.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF452', '.NET Framework', '4.5.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF46', '.NET Framework', '4.6')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF461', '.NET Framework', '4.6.1.')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF', '.NET Framework', '4.6.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF47', '.NET Framework', '4.7')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF471', '.NET Framework', '4.7.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF472', '.NET Framework', '4.7.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('NF48', '.NET Framework', '4.8')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('JDK1', 'Java Development Kit', '1.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('JDK11', 'Java Development Kit', '1.1')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('JDK12', 'Java Development Kit', '1.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE12', 'Java 2 Standard Edition', '1.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE13', 'Java 2 Standard Edition', '1.3')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE14', 'Java 2 Standard Edition', '1.4')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE5', 'Java 2 Standard Edition', '5')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE6', 'Java 2 Standard Edition', '6')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE7', 'Java 2 Standard Edition', '7')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE8', 'Java 2 Standard Edition', '8')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE9', 'Java 2 Standard Edition', '9')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE10', 'Java 2 Standard Edition', '10')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE11', 'Java 2 Standard Edition', '11')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE12', 'Java 2 Standard Edition', '12')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE13', 'Java 2 Standard Edition', '13')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE14', 'Java 2 Standard Edition', '14')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE15', 'Java 2 Standard Edition', '15')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE17', 'Java 2 Standard Edition', '17')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE18', 'Java 2 Standard Edition', '18')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE19', 'Java 2 Standard Edition', '19')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE20', 'Java 2 Standard Edition', '20')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('J2SE21', 'Java 2 Standard Edition', '21')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('PHP72', 'PHP', '7.2')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('PHP73', 'PHP', '7.3')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('PHP74', 'PHP', '7.4')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('PHP8', 'PHP', '8.0')");
            migrationBuilder.Sql("INSERT INTO Plataformas (Apelido, Descricao, Versao) VALUES ('PHP81', 'PHP', '8.1')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Plataformas");
        }
    }
}
