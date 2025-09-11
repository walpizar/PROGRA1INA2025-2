using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class AgregoClsPacienteEntbPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_tbPersonas_id_tipoId",
                table: "Paciente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente");

            migrationBuilder.RenameTable(
                name: "Paciente",
                newName: "tbPaciente");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbPaciente",
                table: "tbPaciente",
                columns: new[] { "id", "tipoId" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbPaciente",
                table: "tbPaciente");

            migrationBuilder.DropColumn(
                name: "Pacienteid",
                table: "tbPersonas");

            migrationBuilder.DropColumn(
                name: "PacientetipoId",
                table: "tbPersonas");

            migrationBuilder.RenameTable(
                name: "tbPaciente",
                newName: "Paciente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paciente",
                table: "Paciente",
                columns: new[] { "id", "tipoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_tbPersonas_id_tipoId",
                table: "Paciente",
                columns: new[] { "id", "tipoId" },
                principalTable: "tbPersonas",
                principalColumns: new[] { "id", "tipoId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
