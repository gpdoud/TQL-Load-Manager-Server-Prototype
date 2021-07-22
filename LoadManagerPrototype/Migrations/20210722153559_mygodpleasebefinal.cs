using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class mygodpleasebefinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Commodity");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Pickup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Pickup",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Load",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Delivery",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Delivery",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Load_UserId",
                table: "Load",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Load_User_UserId",
                table: "Load",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Load_User_UserId",
                table: "Load");

            migrationBuilder.DropIndex(
                name: "IX_Load_UserId",
                table: "Load");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Pickup");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Pickup");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Load");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Delivery");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Commodity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Commodity",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
