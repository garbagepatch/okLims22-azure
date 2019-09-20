using Microsoft.EntityFrameworkCore.Migrations;

namespace okLims.Migrations
{
    public partial class ded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_ScheduleEvent_RequestFK",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestFK",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestFK",
                table: "Request");

            migrationBuilder.AddColumn<bool>(
                name: "AllDay",
                table: "ScheduleEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ScheduleEvent",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleEvent_RequestFK",
                table: "ScheduleEvent",
                column: "RequestFK",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleEvent_Request_RequestFK",
                table: "ScheduleEvent",
                column: "RequestFK",
                principalTable: "Request",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleEvent_Request_RequestFK",
                table: "ScheduleEvent");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleEvent_RequestFK",
                table: "ScheduleEvent");

            migrationBuilder.DropColumn(
                name: "AllDay",
                table: "ScheduleEvent");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ScheduleEvent");

            migrationBuilder.AddColumn<int>(
                name: "RequestFK",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Request_RequestFK",
                table: "Request",
                column: "RequestFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_ScheduleEvent_RequestFK",
                table: "Request",
                column: "RequestFK",
                principalTable: "ScheduleEvent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
