using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbPaciente_tbPersonas_id_tipoId",
                table: "tbPaciente");

            migrationBuilder.DropForeignKey(
                name: "FK_tbPersonas_tbPaciente_Pacienteid_PacientetipoId",
                table: "tbPersonas");

            migrationBuilder.DropIndex(
                name: "IX_tbPersonas_Pacienteid_PacientetipoId",
                table: "tbPersonas");

            migrationBuilder.DropColumn(
                name: "Pacienteid",
                table: "tbPersonas");

            migrationBuilder.DropColumn(
                name: "PacientetipoId",
                table: "tbPersonas");

            migrationBuilder.AlterColumn<string>(
                name: "idPersona",
                table: "tbPaciente",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbPaciente_tbPersonas_idPersona_tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.DropIndex(
                name: "IX_tbPaciente_idPersona_tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.DropColumn(
                name: "tipoIdPersona",
                table: "tbPaciente");

            migrationBuilder.AddColumn<string>(
                name: "Pacienteid",
                table: "tbPersonas",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PacientetipoId",
                table: "tbPersonas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "idPersona",
                table: "tbPaciente",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.CreateIndex(
                name: "IX_tbPersonas_Pacienteid_PacientetipoId",
                table: "tbPersonas",
                columns: new[] { "Pacienteid", "PacientetipoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_tbPaciente_tbPersonas_id_tipoId",
                table: "tbPaciente",
                columns: new[] { "id", "tipoId" },
                principalTable: "tbPersonas",
                principalColumns: new[] { "id", "tipoId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbPersonas_tbPaciente_Pacienteid_PacientetipoId",
                table: "tbPersonas",
                columns: new[] { "Pacienteid", "PacientetipoId" },
                principalTable: "tbPaciente",
                principalColumns: new[] { "id", "tipoId" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
