using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class loadid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Load_LoadId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Pickup_Load_LoadId",
                table: "Pickup");

            migrationBuilder.AlterColumn<int>(
                name: "LoadId",
                table: "Pickup",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LoadId",
                table: "Delivery",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Load_LoadId",
                table: "Delivery",
                column: "LoadId",
                principalTable: "Load",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pickup_Load_LoadId",
                table: "Pickup",
                column: "LoadId",
                principalTable: "Load",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Load_LoadId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Pickup_Load_LoadId",
                table: "Pickup");

            migrationBuilder.AlterColumn<int>(
                name: "LoadId",
                table: "Pickup",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LoadId",
                table: "Delivery",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Load_LoadId",
                table: "Delivery",
                column: "LoadId",
                principalTable: "Load",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pickup_Load_LoadId",
                table: "Pickup",
                column: "LoadId",
                principalTable: "Load",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
