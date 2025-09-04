using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class PersonaMedicoEndermero : Migration
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
                name: "tbDonantes",
                columns: table => new
                {
                    IdDonante = table.Column<int>(type: "int", nullable: false),
                    IdPersona = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonantes", x => x.IdDonante);
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
                name: "tbDonaciones",
                columns: table => new
                {
                    IdDonacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonante = table.Column<int>(type: "int", nullable: false),
                    FechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDonacion = table.Column<int>(type: "int", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonaciones", x => x.IdDonacion);
                    table.ForeignKey(
                        name: "FK_tbDonaciones_tbDonantes_IdDonante",
                        column: x => x.IdDonante,
                        principalTable: "tbDonantes",
                        principalColumn: "IdDonante",
                        onDelete: ReferentialAction.Cascade);
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
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    DonanteIdDonante = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPersonas", x => new { x.id, x.tipoId });
                    table.ForeignKey(
                        name: "FK_tbPersonas_tbDonantes_DonanteIdDonante",
                        column: x => x.DonanteIdDonante,
                        principalTable: "tbDonantes",
                        principalColumn: "IdDonante",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "tbDonacionesActivos",
                columns: table => new
                {
                    IdDonacionActivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonacion = table.Column<int>(type: "int", nullable: false),
                    IdActivo = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    EstadoActivo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonacionesActivos", x => x.IdDonacionActivo);
                    table.ForeignKey(
                        name: "FK_tbDonacionesActivos_tbActivos_IdActivo",
                        column: x => x.IdActivo,
                        principalTable: "tbActivos",
                        principalColumn: "IdActivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbDonacionesActivos_tbDonaciones_IdDonacion",
                        column: x => x.IdDonacion,
                        principalTable: "tbDonaciones",
                        principalColumn: "IdDonacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDonacionesDinero",
                columns: table => new
                {
                    IdDonacionDinero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDonacion = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    Frecuencia = table.Column<int>(type: "int", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonacionesDinero", x => x.IdDonacionDinero);
                    table.ForeignKey(
                        name: "FK_tbDonacionesDinero_tbDonaciones_IdDonacion",
                        column: x => x.IdDonacion,
                        principalTable: "tbDonaciones",
                        principalColumn: "IdDonacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEnfermero",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    area = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    idPersona = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEnfermero", x => new { x.id, x.tipoId });
                    table.ForeignKey(
                        name: "FK_tbEnfermero_tbPersonas_id_tipoId",
                        columns: x => new { x.id, x.tipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_tbActivos_IdCategoria",
                table: "tbActivos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbDevolucion_IdActivoFK",
                table: "tbDevolucion",
                column: "IdActivoFK");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonaciones_IdDonante",
                table: "tbDonaciones",
                column: "IdDonante");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesActivos_IdActivo",
                table: "tbDonacionesActivos",
                column: "IdActivo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesActivos_IdDonacion",
                table: "tbDonacionesActivos",
                column: "IdDonacion");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesDinero_IdDonacion",
                table: "tbDonacionesDinero",
                column: "IdDonacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbPersonas_DonanteIdDonante",
                table: "tbPersonas",
                column: "DonanteIdDonante");

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
                name: "tbDonacionesActivos");

            migrationBuilder.DropTable(
                name: "tbDonacionesDinero");

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
                name: "tbDonaciones");

            migrationBuilder.DropTable(
                name: "tbPersonas");

            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbCategoriasActivos");

            migrationBuilder.DropTable(
                name: "tbDonantes");
        }
    }
}
