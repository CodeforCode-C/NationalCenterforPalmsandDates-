using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalCenterforPalmsandDates.Data.Migrations
{
    public partial class AddModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatesSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatesSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FarmerSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MidName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GrandFatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NationalIdentityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceofNationalIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBANumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FarmerSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SeasonSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Startat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Endat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeasonSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectoreQuantatiesSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PerDayAllowedTones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectoreQuantatiesSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SectorSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpecifiedQuantity = table.Column<int>(type: "int", nullable: false),
                    CityofSupply = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCanceled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectorSettings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankSettings");

            migrationBuilder.DropTable(
                name: "DatesSettings");

            migrationBuilder.DropTable(
                name: "FarmerSettings");

            migrationBuilder.DropTable(
                name: "SeasonSettings");

            migrationBuilder.DropTable(
                name: "SectoreQuantatiesSettings");

            migrationBuilder.DropTable(
                name: "SectorSettings");
        }
    }
}
