using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class basedatos1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCategoriasActivos",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategoriasActivos", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "tbDepartamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcionDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: true),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDepartamento", x => x.idDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "tbEspecialidadesMedicas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEspecialidadesMedicas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbPersonas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPersonas", x => new { x.id, x.tipoId });
                });

            migrationBuilder.CreateTable(
                name: "tbActivos",
                columns: table => new
                {
                    IdActivo = table.Column<int>(type: "int", nullable: false),
                    NombreActivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FechaAdquisicion = table.Column<DateTime>(type: "date", nullable: false),
                    CostoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbActivos", x => x.IdActivo);
                    table.ForeignKey(
                        name: "FK_tbActivos_tbCategoriasActivos_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "tbCategoriasActivos",
                        principalColumn: "IdCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPuestos",
                columns: table => new
                {
                    idPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    idDepartamento = table.Column<int>(type: "int", nullable: false),
                    motivoInactivo = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPuestos", x => x.idPuesto);
                    table.ForeignKey(
                        name: "FK_tbPuestos_tbDepartamento_idDepartamento",
                        column: x => x.idDepartamento,
                        principalTable: "tbDepartamento",
                        principalColumn: "idDepartamento",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEnfermero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    Personaid = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    PersonatipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEnfermero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbEnfermero_tbPersonas_Personaid_PersonatipoId",
                        columns: x => new { x.Personaid, x.PersonatipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" });
                });

            migrationBuilder.CreateTable(
                name: "tbMedico",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbMedico", x => new { x.id, x.tipoId });
                    table.ForeignKey(
                        name: "FK_tbMedico_tbPersonas_id_tipoId",
                        columns: x => new { x.id, x.tipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbDevolucion",
                columns: table => new
                {
                    IdDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDevolucion = table.Column<DateTime>(type: "date", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IdActivoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDevolucion", x => x.IdDevolucion);
                    table.ForeignKey(
                        name: "FK_tbDevolucion_tbActivos_IdActivoFK",
                        column: x => x.IdActivoFK,
                        principalTable: "tbActivos",
                        principalColumn: "IdActivo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbActivos_IdCategoria",
                table: "tbActivos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbDevolucion_IdActivoFK",
                table: "tbDevolucion",
                column: "IdActivoFK");

            migrationBuilder.CreateIndex(
                name: "IX_tbEnfermero_Personaid_PersonatipoId",
                table: "tbEnfermero",
                columns: new[] { "Personaid", "PersonatipoId" });

            migrationBuilder.CreateIndex(
                name: "IX_tbPuestos_idDepartamento",
                table: "tbPuestos",
                column: "idDepartamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbDevolucion");

            migrationBuilder.DropTable(
                name: "tbEnfermero");

            migrationBuilder.DropTable(
                name: "tbEspecialidadesMedicas");

            migrationBuilder.DropTable(
                name: "tbMedico");

            migrationBuilder.DropTable(
                name: "tbPuestos");

            migrationBuilder.DropTable(
                name: "tbActivos");

            migrationBuilder.DropTable(
                name: "tbPersonas");

            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbCategoriasActivos");
        }
    }
}
