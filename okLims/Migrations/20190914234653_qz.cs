using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace okLims.Migrations
{
    public partial class qz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RequestFK",
                table: "Request",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ScheduleEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestFK = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    CategoryColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleEvent", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_ScheduleEvent_RequestFK",
                table: "Request");

            migrationBuilder.DropTable(
                name: "ScheduleEvent");

            migrationBuilder.DropIndex(
                name: "IX_Request_RequestFK",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "RequestFK",
                table: "Request");
        }
    }
}
