using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NationalCenterforPalmsandDates.Data.Migrations
{
    public partial class SeedingUsersandRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                        table: "Security.Roles",
                        columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                        values: new object[] { Guid.NewGuid().ToString(), "User", "User".ToUpper(), Guid.NewGuid().ToString() }
                        );

            migrationBuilder.InsertData(
               table: "Security.Roles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[] { Guid.NewGuid().ToString(), "Admin", "Admin".ToUpper(), Guid.NewGuid().ToString() }
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [AspNetRoles]");
        }
    }
}
