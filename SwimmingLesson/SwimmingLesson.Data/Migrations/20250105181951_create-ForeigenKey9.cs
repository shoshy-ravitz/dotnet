using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeGroup",
                table: "Lessons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodeGroup",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
