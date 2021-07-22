using Microsoft.EntityFrameworkCore.Migrations;

namespace LoadManagerPrototype.Migrations
{
    public partial class finalplease2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "McNumber",
                table: "Carrier",
                maxLength: 8,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Username",
                table: "User",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carrier_McNumber",
                table: "Carrier",
                column: "McNumber",
                unique: true,
                filter: "[McNumber] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Username",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Carrier_McNumber",
                table: "Carrier");

            migrationBuilder.DropColumn(
                name: "McNumber",
                table: "Carrier");
        }
    }
}
