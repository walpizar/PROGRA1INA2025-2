using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class tbPersonalAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbPersonalAdministrativo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personaId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    personaTipoId = table.Column<int>(type: "int", nullable: false),
                    puestoId = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    creadoPor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modificadoPor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPersonalAdministrativo", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbPersonalAdministrativo_tbPersonas_personaId_personaTipoId",
                        columns: x => new { x.personaId, x.personaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbPersonalAdministrativo_tbPuestos_puestoId",
                        column: x => x.puestoId,
                        principalTable: "tbPuestos",
                        principalColumn: "idPuesto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbPersonalAdministrativo_personaId_personaTipoId",
                table: "tbPersonalAdministrativo",
                columns: new[] { "personaId", "personaTipoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbPersonalAdministrativo_puestoId",
                table: "tbPersonalAdministrativo",
                column: "puestoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbPersonalAdministrativo");
        }
    }
}
