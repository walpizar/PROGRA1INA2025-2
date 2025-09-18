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
                name: "tbCategorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategorias", x => x.Id);
                });

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
                name: "tbClientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellido2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    genero = table.Column<short>(type: "smallint", nullable: false),
                    fechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbClientes", x => x.id);
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
                    id = table.Column<int>(type: "int", nullable: false),
                    PersonaTipoId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_tbPersonas", x => new { x.id, x.PersonaTipoId });
                });

            migrationBuilder.CreateTable(
                name: "tbProductos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    precio = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    familia = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProductos", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbProductos_tbCategorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tbCategorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "tbDonantes",
                columns: table => new
                {
                    IdDonante = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    PersonaTipoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonantes", x => x.IdDonante);
                    table.ForeignKey(
                        name: "FK_tbDonantes_tbPersonas_PersonaId_PersonaTipoId",
                        columns: x => new { x.PersonaId, x.PersonaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "PersonaTipoId" },
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
                    Personaid = table.Column<int>(type: "int", nullable: false),
                    PersonaTipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEnfermero", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbEnfermero_tbPersonas_Personaid_PersonaTipoId",
                        columns: x => new { x.Personaid, x.PersonaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "PersonaTipoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbMedico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
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
                        principalColumns: new[] { "id", "PersonaTipoId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaTipoId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    nombre_usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    contraseña = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    rol_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_usuarios_tbPersonas_PersonaId_PersonaTipoId",
                        columns: x => new { x.PersonaId, x.PersonaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "PersonaTipoId" },
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
                name: "tb_tipoAyuda",
                columns: table => new
                {
                    id_tipoAyuda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    id_responsable = table.Column<int>(type: "int", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_usuarioCrea = table.Column<int>(type: "int", nullable: false),
                    id_usuarioUltimaModificacion = table.Column<int>(type: "int", nullable: false),
                    fecha_ultimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipoAyuda", x => x.id_tipoAyuda);
                    table.ForeignKey(
                        name: "FK_tb_tipoAyuda_usuarios_id_responsable",
                        column: x => x.id_responsable,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_tipoAyuda_usuarios_id_usuarioCrea",
                        column: x => x.id_usuarioCrea,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_tipoAyuda_usuarios_id_usuarioUltimaModificacion",
                        column: x => x.id_usuarioUltimaModificacion,
                        principalTable: "usuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clsActivosIdActivo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonacionesActivos", x => x.IdDonacionActivo);
                    table.ForeignKey(
                        name: "FK_tbDonacionesActivos_tbActivos_clsActivosIdActivo",
                        column: x => x.clsActivosIdActivo,
                        principalTable: "tbActivos",
                        principalColumn: "IdActivo");
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

            migrationBuilder.CreateIndex(
                name: "IX_tb_tipoAyuda_id_responsable",
                table: "tb_tipoAyuda",
                column: "id_responsable");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tipoAyuda_id_usuarioCrea",
                table: "tb_tipoAyuda",
                column: "id_usuarioCrea");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tipoAyuda_id_usuarioUltimaModificacion",
                table: "tb_tipoAyuda",
                column: "id_usuarioUltimaModificacion");

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
                name: "IX_tbDonacionesActivos_clsActivosIdActivo",
                table: "tbDonacionesActivos",
                column: "clsActivosIdActivo");

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
                name: "IX_tbDonantes_PersonaId_PersonaTipoId",
                table: "tbDonantes",
                columns: new[] { "PersonaId", "PersonaTipoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbEnfermero_Personaid_PersonaTipoId",
                table: "tbEnfermero",
                columns: new[] { "Personaid", "PersonaTipoId" });

            migrationBuilder.CreateIndex(
                name: "IX_tbProductos_CategoriaId",
                table: "tbProductos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tbPuestos_idDepartamento",
                table: "tbPuestos",
                column: "idDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_PersonaId_PersonaTipoId",
                table: "usuarios",
                columns: new[] { "PersonaId", "PersonaTipoId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tipoAyuda");

            migrationBuilder.DropTable(
                name: "tbClientes");

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
                name: "tbProductos");

            migrationBuilder.DropTable(
                name: "tbPuestos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "tbActivos");

            migrationBuilder.DropTable(
                name: "tbDonaciones");

            migrationBuilder.DropTable(
                name: "tbCategorias");

            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbCategoriasActivos");

            migrationBuilder.DropTable(
                name: "tbDonantes");

            migrationBuilder.DropTable(
                name: "tbPersonas");
        }
    }
}
