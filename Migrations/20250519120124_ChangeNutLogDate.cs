using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriNyan.Migrations
{
    /// <inheritdoc />
    public partial class ChangeNutLogDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "NutritionLogs",
                newName: "Date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "NutritionLogs",
                newName: "CreatedAt");
        }
    }
}
