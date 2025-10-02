using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "Anti-Material Rifle", 1 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "Umbra", 2 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "Salame", 3 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "Blade of Chaos", 4 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "Marreita", 5 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "AK-43", 6 });

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Nome", "PersonagemId" },
                values: new object[] { "El machete", 7 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 24, 118, 38, 209, 105, 199, 172, 148, 41, 183, 253, 8, 163, 12, 197, 69, 173, 161, 228, 16, 82, 170, 20, 254, 232, 64, 151, 237, 75, 190, 64, 124, 213, 70, 58, 115, 181, 198, 143, 29, 162, 185, 231, 239, 229, 163, 54, 229, 100, 38, 230, 22, 139, 190, 137, 158, 1, 234, 115, 249, 206, 15, 172 }, new byte[] { 146, 194, 255, 79, 202, 107, 74, 153, 41, 169, 203, 10, 246, 47, 167, 90, 92, 127, 61, 91, 66, 10, 255, 75, 229, 234, 44, 27, 224, 197, 126, 157, 25, 246, 141, 204, 238, 157, 196, 54, 125, 53, 139, 171, 14, 128, 150, 126, 50, 173, 10, 81, 46, 65, 26, 209, 43, 139, 201, 82, 255, 219, 8, 124, 191, 216, 244, 93, 88, 5, 179, 0, 15, 101, 9, 203, 224, 213, 254, 53, 106, 44, 43, 86, 39, 230, 182, 42, 42, 220, 133, 130, 151, 189, 15, 79, 62, 39, 197, 94, 34, 109, 169, 146, 59, 165, 41, 84, 92, 126, 125, 197, 235, 72, 7, 26, 142, 22, 22, 47, 144, 167, 43, 180, 91, 195, 104, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Arco e Flecha");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Espada");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Machado");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Punho");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nome",
                value: "Chicote");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nome",
                value: "Foice");

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nome",
                value: "Cajado");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 154, 177, 164, 4, 156, 71, 146, 179, 119, 43, 244, 84, 102, 229, 190, 212, 225, 103, 169, 215, 69, 30, 120, 134, 33, 174, 25, 251, 138, 25, 206, 14, 209, 153, 54, 209, 42, 208, 218, 16, 26, 78, 146, 89, 24, 245, 12, 251, 232, 236, 247, 175, 224, 172, 206, 105, 241, 190, 195, 76, 236, 182, 249 }, new byte[] { 92, 10, 159, 235, 112, 68, 125, 61, 44, 181, 38, 17, 71, 160, 243, 172, 138, 109, 204, 183, 12, 247, 122, 1, 236, 152, 94, 130, 32, 139, 125, 28, 217, 194, 229, 180, 101, 25, 234, 71, 70, 122, 152, 216, 167, 72, 233, 94, 160, 167, 177, 50, 249, 25, 130, 49, 83, 84, 10, 21, 120, 47, 144, 200, 243, 156, 224, 252, 185, 28, 52, 34, 180, 251, 72, 35, 71, 235, 105, 223, 212, 202, 138, 171, 141, 231, 210, 141, 104, 147, 245, 149, 150, 132, 66, 191, 113, 9, 201, 18, 65, 248, 230, 109, 195, 203, 216, 13, 235, 171, 123, 117, 118, 145, 5, 40, 28, 196, 170, 135, 35, 217, 159, 52, 109, 246, 187, 159 } });
        }
    }
}
