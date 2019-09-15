using Microsoft.EntityFrameworkCore.Migrations;

namespace okLims.Migrations
{
    public partial class dead : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_RequestState_RequestFK",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestFK",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestFK",
                table: "RequestState");

            migrationBuilder.DropColumn(
                name: "RequestFK",
                table: "Request");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestFK",
                table: "RequestState",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RequestFK",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Request_RequestFK",
                table: "Request",
                column: "RequestFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_RequestState_RequestFK",
                table: "Request",
                column: "RequestFK",
                principalTable: "RequestState",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
