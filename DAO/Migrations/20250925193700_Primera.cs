using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_tipoAyuda",
                columns: table => new
                {
                    id_tipoAyuda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    id_responsable = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    personaTipoId_responsable = table.Column<int>(type: "int", nullable: false),
                    id_usuarioCrea = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    personaTipoId_usuarioCrea = table.Column<int>(type: "int", nullable: false),
                    id_usuarioUltimaModificacion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    personaTipoId_usuarioUltimaModificacion = table.Column<int>(type: "int", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_ultimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tipoAyuda", x => x.id_tipoAyuda);
                });

            migrationBuilder.CreateTable(
                name: "tbCategoriaActivos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategoriaActivos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbDepartamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigoDepartamento = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    descripcionDepartamento = table.Column<string>(type: "NVARCHAR(250)", maxLength: 250, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    usuario_crea = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    usuario_ult_mod = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDepartamento", x => x.idDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "tbEspecialidadMedica",
                columns: table => new
                {
                    idEspecialidadMedica = table.Column<int>(type: "int", nullable: false),
                    nombreEspecialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEspecialidadMedica", x => x.idEspecialidadMedica);
                });

            migrationBuilder.CreateTable(
                name: "tbPermisos",
                columns: table => new
                {
                    idPermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePermiso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPermisos", x => x.idPermiso);
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
                name: "tbRoles",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreRol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRoles", x => x.idRol);
                });

            migrationBuilder.CreateTable(
                name: "tbActivos",
                columns: table => new
                {
                    idActivo = table.Column<int>(type: "int", nullable: false),
                    nombreActivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CantidadDisponible = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fechaAdquisicion = table.Column<DateTime>(type: "date", nullable: false),
                    costoUnitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ubicacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    usuarioCreacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    usuarioModificacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    idCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbActivos", x => x.idActivo);
                    table.ForeignKey(
                        name: "FK_tbActivos_tbCategoriaActivos_idCategoria",
                        column: x => x.idCategoria,
                        principalTable: "tbCategoriaActivos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPuestos",
                columns: table => new
                {
                    idPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Nombre = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "NVARCHAR(250)", maxLength: 250, nullable: true),
                    idDepartamento = table.Column<int>(type: "int", nullable: false),
                    motivoInactivo = table.Column<string>(type: "NVARCHAR(300)", maxLength: 300, nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "DATETIME2", nullable: false),
                    usuario_crea = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "DATETIME2", nullable: true),
                    usuario_ult_mod = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true)
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
                name: "tbMedico",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    fechaCrea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioCrea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioUltMod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "tbPaciente",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    estadoCivil = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    fecha_crea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_crea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fecha_ult_mod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuario_ult_mod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPaciente", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbPaciente_tbPersonas_id_tipoId",
                        columns: x => new { x.id, x.tipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbUsuarios",
                columns: table => new
                {
                    personaId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    personaTipoId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    nombre_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbUsuarios", x => new { x.personaId, x.personaTipoId });
                    table.ForeignKey(
                        name: "FK_tbUsuarios_tbPersonas_personaId_personaTipoId",
                        columns: x => new { x.personaId, x.personaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbRolPermiso",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false),
                    idPermiso = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRolPermiso", x => new { x.idRol, x.idPermiso });
                    table.ForeignKey(
                        name: "FK_tbRolPermiso_tbPermisos_idPermiso",
                        column: x => x.idPermiso,
                        principalTable: "tbPermisos",
                        principalColumn: "idPermiso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbRolPermiso_tbRoles_idRol",
                        column: x => x.idRol,
                        principalTable: "tbRoles",
                        principalColumn: "idRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDevolucion",
                columns: table => new
                {
                    idDevolucion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaDevolucion = table.Column<DateTime>(type: "date", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    idActivoFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDevolucion", x => x.idDevolucion);
                    table.ForeignKey(
                        name: "FK_tbDevolucion_tbActivos_idActivoFK",
                        column: x => x.idActivoFK,
                        principalTable: "tbActivos",
                        principalColumn: "idActivo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbActivos_idCategoria",
                table: "tbActivos",
                column: "idCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbDevolucion_idActivoFK",
                table: "tbDevolucion",
                column: "idActivoFK");

            migrationBuilder.CreateIndex(
                name: "IX_tbPaciente_id_tipoId",
                table: "tbPaciente",
                columns: new[] { "id", "tipoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbPuestos_idDepartamento",
                table: "tbPuestos",
                column: "idDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_tbRolPermiso_idPermiso",
                table: "tbRolPermiso",
                column: "idPermiso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tipoAyuda");

            migrationBuilder.DropTable(
                name: "tbDevolucion");

            migrationBuilder.DropTable(
                name: "tbEspecialidadMedica");

            migrationBuilder.DropTable(
                name: "tbMedico");

            migrationBuilder.DropTable(
                name: "tbPaciente");

            migrationBuilder.DropTable(
                name: "tbPuestos");

            migrationBuilder.DropTable(
                name: "tbRolPermiso");

            migrationBuilder.DropTable(
                name: "tbUsuarios");

            migrationBuilder.DropTable(
                name: "tbActivos");

            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbPermisos");

            migrationBuilder.DropTable(
                name: "tbRoles");

            migrationBuilder.DropTable(
                name: "tbPersonas");

            migrationBuilder.DropTable(
                name: "tbCategoriaActivos");
        }
    }
}
