using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Apsiyon.Infrastructure.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalID = table.Column<int>(type: "int", nullable: false),
                    UserEMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhone = table.Column<int>(type: "int", nullable: false),
                    UserNumberPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ApartmentBloc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmpty = table.Column<bool>(type: "bit", nullable: false),
                    ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorNumber = table.Column<int>(type: "int", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "int", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_UserId",
                table: "Apartments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
