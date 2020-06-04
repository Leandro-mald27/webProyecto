using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class inicialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlmacenamientoProducto",
                columns: table => new
                {
                    Idregistro = table.Column<string>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    NumeroLote = table.Column<string>(nullable: true),
                    NumeroLoteAgricola = table.Column<string>(nullable: true),
                    Etapas = table.Column<string>(nullable: true),
                    Cantidad = table.Column<string>(nullable: true),
                    Responsable = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlmacenamientoProducto", x => x.Idregistro);
                });

            migrationBuilder.CreateTable(
                name: "Productores",
                columns: table => new
                {
                    Cedula = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    CodigoProductor = table.Column<string>(nullable: true),
                    NumeroTelefonico = table.Column<string>(nullable: true),
                    Afiliacion = table.Column<string>(nullable: true),
                    Actividad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productores", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlmacenamientoProducto");

            migrationBuilder.DropTable(
                name: "Productores");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
