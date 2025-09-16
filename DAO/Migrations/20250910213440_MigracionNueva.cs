using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class MigracionNueva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostoUnitario",
                table: "tbActivos");

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
                name: "tbDonantes",
                columns: table => new
                {
                    IdDonante = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<string>(type: "nvarchar(20)", nullable: false),
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
                        principalColumns: new[] { "id", "tipoId" },
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_tbDonantes_PersonaId_PersonaTipoId",
                table: "tbDonantes",
                columns: new[] { "PersonaId", "PersonaTipoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbProductos_CategoriaId",
                table: "tbProductos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbClientes");

            migrationBuilder.DropTable(
                name: "tbDonacionesActivos");

            migrationBuilder.DropTable(
                name: "tbDonacionesDinero");

            migrationBuilder.DropTable(
                name: "tbProductos");

            migrationBuilder.DropTable(
                name: "tbDonaciones");

            migrationBuilder.DropTable(
                name: "tbCategorias");

            migrationBuilder.DropTable(
                name: "tbDonantes");

            migrationBuilder.AddColumn<decimal>(
                name: "CostoUnitario",
                table: "tbActivos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
