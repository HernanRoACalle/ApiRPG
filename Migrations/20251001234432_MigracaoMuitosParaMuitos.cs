using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADE",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADE", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADE_TB_HABILIDADE_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADE_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADE",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 20, 12, 35, 175, 88, 232, 183, 247, 172, 241, 105, 233, 73, 46, 131, 97, 170, 72, 225, 128, 85, 25, 14, 15, 121, 198, 89, 55, 111, 87, 105, 47, 114, 14, 141, 25, 186, 242, 79, 83, 250, 226, 122, 242, 63, 44, 208, 78, 125, 135, 127, 27, 165, 125, 59, 74, 147, 129, 28, 174, 136, 5, 58, 157 }, new byte[] { 202, 30, 96, 64, 56, 4, 67, 4, 92, 170, 231, 195, 89, 137, 173, 179, 4, 236, 194, 16, 208, 131, 100, 174, 163, 220, 71, 129, 65, 243, 183, 168, 49, 209, 2, 0, 101, 155, 101, 239, 58, 174, 116, 52, 73, 154, 28, 121, 45, 228, 135, 4, 231, 207, 98, 72, 192, 3, 58, 249, 116, 218, 212, 6, 1, 96, 3, 218, 233, 193, 21, 138, 136, 68, 211, 237, 165, 139, 99, 106, 9, 25, 40, 170, 96, 189, 213, 98, 49, 162, 106, 241, 228, 226, 164, 210, 161, 66, 141, 47, 44, 2, 207, 19, 173, 157, 221, 183, 135, 207, 12, 209, 86, 79, 231, 196, 3, 253, 173, 27, 114, 184, 8, 33, 198, 95, 105, 9 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADE",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADE_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADE",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADE");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADE");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 24, 118, 38, 209, 105, 199, 172, 148, 41, 183, 253, 8, 163, 12, 197, 69, 173, 161, 228, 16, 82, 170, 20, 254, 232, 64, 151, 237, 75, 190, 64, 124, 213, 70, 58, 115, 181, 198, 143, 29, 162, 185, 231, 239, 229, 163, 54, 229, 100, 38, 230, 22, 139, 190, 137, 158, 1, 234, 115, 249, 206, 15, 172 }, new byte[] { 146, 194, 255, 79, 202, 107, 74, 153, 41, 169, 203, 10, 246, 47, 167, 90, 92, 127, 61, 91, 66, 10, 255, 75, 229, 234, 44, 27, 224, 197, 126, 157, 25, 246, 141, 204, 238, 157, 196, 54, 125, 53, 139, 171, 14, 128, 150, 126, 50, 173, 10, 81, 46, 65, 26, 209, 43, 139, 201, 82, 255, 219, 8, 124, 191, 216, 244, 93, 88, 5, 179, 0, 15, 101, 9, 203, 224, 213, 254, 53, 106, 44, 43, 86, 39, 230, 182, 42, 42, 220, 133, 130, 151, 189, 15, 79, 62, 39, 197, 94, 34, 109, 169, 146, 59, 165, 41, 84, 92, 126, 125, 197, 235, 72, 7, 26, 142, 22, 22, 47, 144, 167, 43, 180, 91, 195, 104, 160 } });
        }
    }
}
