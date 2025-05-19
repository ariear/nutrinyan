using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriNyan.Migrations
{
    /// <inheritdoc />
    public partial class MealFoodChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Units_UnitId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_UnitId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Meals",
                newName: "Date");

            migrationBuilder.AddColumn<float>(
                name: "Gula",
                table: "MealItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Karbohidrat",
                table: "MealItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Lemak",
                table: "MealItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Protein",
                table: "MealItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Serat",
                table: "MealItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "MealItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MealItems_UnitId",
                table: "MealItems",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_MealItems_Units_UnitId",
                table: "MealItems",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MealItems_Units_UnitId",
                table: "MealItems");

            migrationBuilder.DropIndex(
                name: "IX_MealItems_UnitId",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "Gula",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "Karbohidrat",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "Lemak",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "Serat",
                table: "MealItems");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "MealItems");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Meals",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Foods",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UnitId",
                table: "Foods",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Units_UnitId",
                table: "Foods",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
