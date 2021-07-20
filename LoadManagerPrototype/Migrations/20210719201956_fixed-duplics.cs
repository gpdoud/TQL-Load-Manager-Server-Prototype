using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class fixedduplics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Sheds_DropShedId",
                table: "Loads");

            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Sheds_PickShedId",
                table: "Loads");

            migrationBuilder.DropColumn(
                name: "DropId",
                table: "Loads");

            migrationBuilder.DropColumn(
                name: "PickId",
                table: "Loads");

            migrationBuilder.AlterColumn<int>(
                name: "PickShedId",
                table: "Loads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DropShedId",
                table: "Loads",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Sheds_DropShedId",
                table: "Loads",
                column: "DropShedId",
                principalTable: "Sheds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Sheds_PickShedId",
                table: "Loads",
                column: "PickShedId",
                principalTable: "Sheds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Sheds_DropShedId",
                table: "Loads");

            migrationBuilder.DropForeignKey(
                name: "FK_Loads_Sheds_PickShedId",
                table: "Loads");

            migrationBuilder.AlterColumn<int>(
                name: "PickShedId",
                table: "Loads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DropShedId",
                table: "Loads",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DropId",
                table: "Loads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PickId",
                table: "Loads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Sheds_DropShedId",
                table: "Loads",
                column: "DropShedId",
                principalTable: "Sheds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loads_Sheds_PickShedId",
                table: "Loads",
                column: "PickShedId",
                principalTable: "Sheds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
