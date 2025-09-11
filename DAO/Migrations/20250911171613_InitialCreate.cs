using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    estadoCivil = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    referencia = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => new { x.id, x.tipoId });
                    table.ForeignKey(
                        name: "FK_Paciente_tbPersonas_id_tipoId",
                        columns: x => new { x.id, x.tipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");
        }
    }
}
