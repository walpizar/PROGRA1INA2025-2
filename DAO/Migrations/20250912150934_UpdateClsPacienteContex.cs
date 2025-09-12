using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class UpdateClsPacienteContex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbPaciente_tbPersonas_idPersona_tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.DropIndex(
                name: "IX_tbPaciente_idPersona_tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.DropColumn(
                name: "idPersona",
                table: "tbPaciente");

            migrationBuilder.DropColumn(
                name: "tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.AddForeignKey(
                name: "FK_tbPaciente_tbPersonas_id_tipoId",
                table: "tbPaciente",
                columns: new[] { "id", "tipoId" },
                principalTable: "tbPersonas",
                principalColumns: new[] { "id", "tipoId" },
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbPaciente_tbPersonas_id_tipoId",
                table: "tbPaciente");

            migrationBuilder.AddColumn<string>(
                name: "idPersona",
                table: "tbPaciente",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "tipoIdPersona",
                table: "tbPaciente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbPaciente_idPersona_tipoIdPersona",
                table: "tbPaciente",
                columns: new[] { "idPersona", "tipoIdPersona" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbPaciente_tbPersonas_idPersona_tipoIdPersona",
                table: "tbPaciente",
                columns: new[] { "idPersona", "tipoIdPersona" },
                principalTable: "tbPersonas",
                principalColumns: new[] { "id", "tipoId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
