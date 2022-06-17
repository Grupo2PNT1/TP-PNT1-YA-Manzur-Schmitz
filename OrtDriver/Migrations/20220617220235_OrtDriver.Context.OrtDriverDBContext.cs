using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrtDriver.Migrations
{
    public partial class OrtDriverContextOrtDriverDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conductores",
                columns: table => new
                {
                    ConductorId = table.Column<string>(nullable: false),
                    ConductorName = table.Column<string>(nullable: true),
                    ConductorSurname = table.Column<string>(nullable: true),
                    Dni = table.Column<int>(nullable: false),
                    FechaInscripto = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductores", x => x.ConductorId);
                });

            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConductorId = table.Column<string>(nullable: true),
                    Origen = table.Column<string>(nullable: true),
                    Destino = table.Column<string>(nullable: true),
                    FechaInscripto = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viajes_Conductores_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Conductores",
                        principalColumn: "ConductorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viajes_ConductorId",
                table: "Viajes",
                column: "ConductorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viajes");

            migrationBuilder.DropTable(
                name: "Conductores");
        }
    }
}
