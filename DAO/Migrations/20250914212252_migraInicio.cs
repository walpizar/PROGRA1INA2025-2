using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class migraInicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Modulo",
                columns: table => new
                {
                    id_modulo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_modulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    descripcion_modulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Modulo", x => x.id_modulo);
                });

            migrationBuilder.CreateTable(
                name: "tb_Roles",
                columns: table => new
                {
                    id_rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_rol = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    descripcion_rol = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    estado_rol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Roles", x => x.id_rol);
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
                name: "tb_Permisos",
                columns: table => new
                {
                    id_modulo = table.Column<int>(type: "int", nullable: false),
                    id_rol = table.Column<int>(type: "int", nullable: false),
                    consultar = table.Column<bool>(type: "bit", nullable: false),
                    crear = table.Column<bool>(type: "bit", nullable: false),
                    editar = table.Column<bool>(type: "bit", nullable: false),
                    eliminar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Permisos", x => new { x.id_rol, x.id_modulo });
                    table.ForeignKey(
                        name: "FK_tb_Permisos_tb_Modulo_id_modulo",
                        column: x => x.id_modulo,
                        principalTable: "tb_Modulo",
                        principalColumn: "id_modulo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Permisos_tb_Roles_id_rol",
                        column: x => x.id_rol,
                        principalTable: "tb_Roles",
                        principalColumn: "id_rol",
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

            migrationBuilder.CreateIndex(
                name: "IX_tb_Permisos_id_modulo",
                table: "tb_Permisos",
                column: "id_modulo");

            migrationBuilder.CreateIndex(
                name: "IX_tbActivos_IdCategoria",
                table: "tbActivos",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_tbDevolucion_IdActivoFK",
                table: "tbDevolucion",
                column: "IdActivoFK");

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
                name: "IX_tbPuestos_idDepartamento",
                table: "tbPuestos",
                column: "idDepartamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Permisos");

            migrationBuilder.DropTable(
                name: "tbDevolucion");

            migrationBuilder.DropTable(
                name: "tbDonacionesActivos");

            migrationBuilder.DropTable(
                name: "tbDonacionesDinero");

            migrationBuilder.DropTable(
                name: "tbEspecialidadesMedicas");

            migrationBuilder.DropTable(
                name: "tbPuestos");

            migrationBuilder.DropTable(
                name: "tb_Modulo");

            migrationBuilder.DropTable(
                name: "tb_Roles");

            migrationBuilder.DropTable(
                name: "tbActivos");

            migrationBuilder.DropTable(
                name: "tbDonaciones");

            migrationBuilder.DropTable(
                name: "tbDepartamento");

            migrationBuilder.DropTable(
                name: "tbCategoriasActivos");
        }
    }
}
