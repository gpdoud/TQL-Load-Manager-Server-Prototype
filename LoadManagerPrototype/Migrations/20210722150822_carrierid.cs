using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class carrierid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispatcher_Carrier_CarrierId",
                table: "Dispatcher");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver");

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Driver",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Dispatcher",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dispatcher_Carrier_CarrierId",
                table: "Dispatcher",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dispatcher_Carrier_CarrierId",
                table: "Dispatcher");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver");

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Driver",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CarrierId",
                table: "Dispatcher",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Dispatcher_Carrier_CarrierId",
                table: "Dispatcher",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Carrier_CarrierId",
                table: "Driver",
                column: "CarrierId",
                principalTable: "Carrier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
