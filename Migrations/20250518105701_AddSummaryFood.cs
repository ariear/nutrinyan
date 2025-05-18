using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriNyan.Migrations
{
    /// <inheritdoc />
    public partial class AddSummaryFood : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Units",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<float>(
                name: "Gula",
                table: "Foods",
                type: "real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "Real");

            migrationBuilder.AddColumn<string>(
                name: "Summary",
                table: "Foods",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Units");

            migrationBuilder.DropColumn(
                name: "Summary",
                table: "Foods");

            migrationBuilder.AlterColumn<float>(
                name: "Gula",
                table: "Foods",
                type: "Real",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
