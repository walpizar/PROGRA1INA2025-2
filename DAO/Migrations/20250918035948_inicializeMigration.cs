using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class inicializeMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbCategoriaActivos",
                columns: table => new
                {
                    idCategoriaActivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCategoriaActivo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCategoriaActivos", x => x.idCategoriaActivo);
                });

            migrationBuilder.CreateTable(
                name: "tbDepartamento",
                columns: table => new
                {
                    idDepartamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDepartamento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    usuarioCreacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioModificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDepartamento", x => x.idDepartamento);
                });

            migrationBuilder.CreateTable(
                name: "tbEspecialidadMedica",
                columns: table => new
                {
                    idEspecialidadMedica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEspecialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEspecialidadMedica", x => x.idEspecialidadMedica);
                });

            migrationBuilder.CreateTable(
                name: "tbModulo",
                columns: table => new
                {
                    idModulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreModulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcionModulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbModulo", x => x.idModulo);
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
                name: "tbPuestos",
                columns: table => new
                {
                    idPuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePuesto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPuestos", x => x.idPuesto);
                });

            migrationBuilder.CreateTable(
                name: "tbRoles",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreRol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    descripcionRol = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estadoRol = table.Column<bool>(type: "bit", nullable: false)
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
                    costoUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                        principalColumn: "idCategoriaActivo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDonantes",
                columns: table => new
                {
                    personaId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    personaTipoId = table.Column<int>(type: "int", nullable: false),
                    idDonante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonantes", x => new { x.personaId, x.personaTipoId });
                    table.ForeignKey(
                        name: "FK_tbDonantes_tbPersonas_personaId_personaTipoId",
                        columns: x => new { x.personaId, x.personaTipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbEnfermeros",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    tipoId = table.Column<int>(type: "int", nullable: false),
                    area = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    numeroColegiado = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    fechaCrea = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioCrea = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    fechaUltMod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    usuarioUltMod = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbEnfermeros", x => new { x.id, x.tipoId });
                    table.ForeignKey(
                        name: "FK_tbEnfermeros_tbPersonas_id_tipoId",
                        columns: x => new { x.id, x.tipoId },
                        principalTable: "tbPersonas",
                        principalColumns: new[] { "id", "tipoId" },
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
                name: "tbUsuarios",
                columns: table => new
                {
                    personaId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    personaTipoId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    nombre_usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contrasena = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbPermisos",
                columns: table => new
                {
                    idModulo = table.Column<int>(type: "int", nullable: false),
                    idRol = table.Column<int>(type: "int", nullable: false),
                    consultar = table.Column<bool>(type: "bit", nullable: false),
                    crear = table.Column<bool>(type: "bit", nullable: false),
                    editar = table.Column<bool>(type: "bit", nullable: false),
                    eliminar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbPermisos", x => new { x.idRol, x.idModulo });
                    table.ForeignKey(
                        name: "FK_tbPermisos_tbModulo_idModulo",
                        column: x => x.idModulo,
                        principalTable: "tbModulo",
                        principalColumn: "idModulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbPermisos_tbRoles_idRol",
                        column: x => x.idRol,
                        principalTable: "tbRoles",
                        principalColumn: "idRol",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbRolPermiso",
                columns: table => new
                {
                    idRol = table.Column<int>(type: "int", nullable: false),
                    idPermiso = table.Column<int>(type: "int", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    RolidRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbRolPermiso", x => new { x.idRol, x.idPermiso });
                    table.ForeignKey(
                        name: "FK_tbRolPermiso_tbRoles_RolidRol",
                        column: x => x.RolidRol,
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

            migrationBuilder.CreateTable(
                name: "tbDonaciones",
                columns: table => new
                {
                    idDonacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaDonacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tipoDonacion = table.Column<int>(type: "int", nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    donantepersonaId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    donantepersonaTipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonaciones", x => x.idDonacion);
                    table.ForeignKey(
                        name: "FK_tbDonaciones_tbDonantes_donantepersonaId_donantepersonaTipoId",
                        columns: x => new { x.donantepersonaId, x.donantepersonaTipoId },
                        principalTable: "tbDonantes",
                        principalColumns: new[] { "personaId", "personaTipoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDonacionesActivos",
                columns: table => new
                {
                    idDonacionActivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDonacion = table.Column<int>(type: "int", nullable: false),
                    idActivo = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    estadoActivo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonacionesActivos", x => x.idDonacionActivo);
                    table.ForeignKey(
                        name: "FK_tbDonacionesActivos_tbActivos_idActivo",
                        column: x => x.idActivo,
                        principalTable: "tbActivos",
                        principalColumn: "idActivo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbDonacionesActivos_tbDonaciones_idDonacion",
                        column: x => x.idDonacion,
                        principalTable: "tbDonaciones",
                        principalColumn: "idDonacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbDonacionesDinero",
                columns: table => new
                {
                    idDonacionDinero = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idDonacion = table.Column<int>(type: "int", nullable: false),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tipoTransaccion = table.Column<int>(type: "int", nullable: false),
                    frecuencia = table.Column<int>(type: "int", nullable: false),
                    moneda = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbDonacionesDinero", x => x.idDonacionDinero);
                    table.ForeignKey(
                        name: "FK_tbDonacionesDinero_tbDonaciones_idDonacion",
                        column: x => x.idDonacion,
                        principalTable: "tbDonaciones",
                        principalColumn: "idDonacion",
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
                name: "IX_tbDonaciones_donantepersonaId_donantepersonaTipoId",
                table: "tbDonaciones",
                columns: new[] { "donantepersonaId", "donantepersonaTipoId" });

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesActivos_idActivo",
                table: "tbDonacionesActivos",
                column: "idActivo");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesActivos_idDonacion",
                table: "tbDonacionesActivos",
                column: "idDonacion");

            migrationBuilder.CreateIndex(
                name: "IX_tbDonacionesDinero_idDonacion",
                table: "tbDonacionesDinero",
                column: "idDonacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbPermisos_idModulo",
                table: "tbPermisos",
                column: "idModulo");

            migrationBuilder.CreateIndex(
                name: "IX_tbRolPermiso_RolidRol",
                table: "tbRolPermiso",
                column: "RolidRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbDevolucion");

            migrationBuilder.DropTable(
                name: "tbDonacionesActivos");

            migrationBuilder.DropTable(
                name: "tbDonacionesDinero");

            migrationBuilder.DropTable(
                name: "tbEnfermeros");

            migrationBuilder.DropTable(
                name: "tbEspecialidadMedica");

            migrationBuilder.DropTable(
                name: "tbMedico");

            migrationBuilder.DropTable(
                name: "tbPermisos");

            migrationBuilder.DropTable(
                name: "tbPuestos");

            migrationBuilder.DropTable(
                name: "tbRolPermiso");

            migrationBuilder.DropTable(
                name: "tbUsuarios");

            migrationBuilder.DropTable(
                name: "tbActivos");

            migrationBuilder.DropTable(
                name: "tbDonaciones");

            migrationBuilder.DropTable(
                name: "tbModulo");

            migrationBuilder.DropTable(
                name: "tbRoles");

            migrationBuilder.DropTable(
                name: "tbCategoriaActivos");

            migrationBuilder.DropTable(
                name: "tbDonantes");

            migrationBuilder.DropTable(
                name: "tbPersonas");
        }
    }
}
