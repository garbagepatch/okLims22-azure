using Microsoft.EntityFrameworkCore.Migrations;

namespace okLims.Migrations
{
    public partial class qeqwqe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleEvent_Request_RequestFK",
                table: "ScheduleEvent");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleEvent_RequestFK",
                table: "ScheduleEvent");

            migrationBuilder.RenameColumn(
                name: "RequestFK",
                table: "ScheduleEvent",
                newName: "StateId");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleEventId",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleEvent_StateId",
                table: "ScheduleEvent",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ScheduleEventId",
                table: "Request",
                column: "ScheduleEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_ScheduleEvent_ScheduleEventId",
                table: "Request",
                column: "ScheduleEventId",
                principalTable: "ScheduleEvent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleEvent_RequestState_StateId",
                table: "ScheduleEvent",
                column: "StateId",
                principalTable: "RequestState",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_ScheduleEvent_ScheduleEventId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleEvent_RequestState_StateId",
                table: "ScheduleEvent");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleEvent_StateId",
                table: "ScheduleEvent");

            migrationBuilder.DropIndex(
                name: "IX_Request_ScheduleEventId",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "ScheduleEventId",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "ScheduleEvent",
                newName: "RequestFK");

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
    }
}
