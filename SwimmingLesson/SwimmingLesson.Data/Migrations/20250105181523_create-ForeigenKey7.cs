using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CodeGroup",
                table: "Lessons",
                newName: "CodeGroup1");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons",
                newName: "IX_Lessons_CodeGroup1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_CodeGroup1",
                table: "Lessons",
                column: "CodeGroup1",
                principalTable: "group",
                principalColumn: "CodeGroup",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup1",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CodeGroup1",
                table: "Lessons",
                newName: "CodeGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CodeGroup1",
                table: "Lessons",
                newName: "IX_Lessons_CodeGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_CodeGroup",
                table: "Lessons",
                column: "CodeGroup",
                principalTable: "group",
                principalColumn: "CodeGroup",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
