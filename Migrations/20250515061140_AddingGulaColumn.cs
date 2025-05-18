using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriNyan.Migrations
{
    /// <inheritdoc />
    public partial class AddingGulaColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Gula",
                table: "Foods",
                type: "Real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gula",
                table: "Foods");
        }
    }
}
