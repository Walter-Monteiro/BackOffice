using Microsoft.EntityFrameworkCore.Migrations;

namespace Crude.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Espacos",
                columns: new[] { "Id", "CidadeId", "Classificacao", "Latitude", "Longitude", "NomeConhecido", "NomeOficial" },
                values: new object[] { 1, null, 5.0, 39.600000000000001, -8.4000000000000004, "Aka", "Café Acadêmico" });

            migrationBuilder.InsertData(
                table: "Perguntas",
                columns: new[] { "Id", "QuestionarioId", "Texto" },
                values: new object[] { 1, null, "Olá Mundo!!! Quem és tu?" });

            migrationBuilder.InsertData(
                table: "Questionarios",
                columns: new[] { "Id", "AlunoId", "Nome", "QuestionarioFK", "QuestionariosId" },
                values: new object[] { 1, null, "Quen és tu?", 0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Espacos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Perguntas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questionarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
