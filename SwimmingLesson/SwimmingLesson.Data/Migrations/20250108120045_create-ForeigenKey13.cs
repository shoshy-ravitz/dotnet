using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "GroupCodeGroup",
                table: "Lessons",
                newName: "CodeGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_GroupCodeGroup",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CodeGroup",
                table: "Lessons",
                newName: "GroupCodeGroup");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons",
                newName: "IX_Lessons_GroupCodeGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup",
                principalTable: "group",
                principalColumn: "CodeGroup",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
