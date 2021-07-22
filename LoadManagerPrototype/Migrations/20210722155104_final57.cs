using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class final57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Pickup");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Pickup");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Delivery");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Delivery");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CommodityPickup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "CommodityPickup",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CommodityDelivery",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "CommodityDelivery",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CommodityPickup");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "CommodityPickup");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CommodityDelivery");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "CommodityDelivery");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Pickup",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Pickup",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Delivery",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Delivery",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }
    }
}
