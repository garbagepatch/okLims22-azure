using Microsoft.EntityFrameworkCore.Migrations;

namespace okLims.Migrations
{
    public partial class tertiary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventFK",
                table: "Request",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventFK",
                table: "Request");
        }
    }
}
