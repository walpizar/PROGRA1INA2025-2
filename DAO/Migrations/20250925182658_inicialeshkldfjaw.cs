using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class inicialeshkldfjaw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbDonacion_tbDonante_donantepersonaId_donantepersonaTipoId",
                table: "tbDonacion");

            migrationBuilder.DropIndex(
                name: "IX_tbDonacion_donantepersonaId_donantepersonaTipoId",
                table: "tbDonacion");

            migrationBuilder.DropColumn(
                name: "donanteId",
                table: "tbDonacion");

            migrationBuilder.DropColumn(
                name: "donantepersonaTipoId",
                table: "tbDonacion");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacion_donantepersonaId_donanteTipoId",
                table: "tbDonacion",
                columns: new[] { "donantepersonaId", "donanteTipoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbDonacion_tbDonante_donantepersonaId_donanteTipoId",
                table: "tbDonacion",
                columns: new[] { "donantepersonaId", "donanteTipoId" },
                principalTable: "tbDonante",
                principalColumns: new[] { "personaId", "personaTipoId" },
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbDonacion_tbDonante_donantepersonaId_donanteTipoId",
                table: "tbDonacion");

            migrationBuilder.DropIndex(
                name: "IX_tbDonacion_donantepersonaId_donanteTipoId",
                table: "tbDonacion");

            migrationBuilder.AddColumn<string>(
                name: "donanteId",
                table: "tbDonacion",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "donantepersonaTipoId",
                table: "tbDonacion",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacion_donantepersonaId_donantepersonaTipoId",
                table: "tbDonacion",
                columns: new[] { "donantepersonaId", "donantepersonaTipoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbDonacion_tbDonante_donantepersonaId_donantepersonaTipoId",
                table: "tbDonacion",
                columns: new[] { "donantepersonaId", "donantepersonaTipoId" },
                principalTable: "tbDonante",
                principalColumns: new[] { "personaId", "personaTipoId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
