using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAO.Migrations
{
    /// <inheritdoc />
    public partial class AjustarClaveUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "tbUsuarios");

            migrationBuilder.RenameColumn(
                name: "nombre_usuario",
                table: "tbUsuarios",
                newName: "nombre_Usuario");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_Usuario",
                table: "tbUsuarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "idRol",
                table: "tbUsuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idRol",
                table: "tbUsuarios");

            migrationBuilder.RenameColumn(
                name: "nombre_Usuario",
                table: "tbUsuarios",
                newName: "nombre_usuario");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_usuario",
                table: "tbUsuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "tbUsuarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
