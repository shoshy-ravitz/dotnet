using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup1",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CodeGroup1",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CodeGroup1",
                table: "Lessons",
                newName: "CodeGroup");

            migrationBuilder.AddColumn<int>(
                name: "GroupCodeGroup",
                table: "Lessons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup",
                principalTable: "group",
                principalColumn: "CodeGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_GroupCodeGroup",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "GroupCodeGroup",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "CodeGroup",
                table: "Lessons",
                newName: "CodeGroup1");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CodeGroup1",
                table: "Lessons",
                column: "CodeGroup1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_CodeGroup1",
                table: "Lessons",
                column: "CodeGroup1",
                principalTable: "group",
                principalColumn: "CodeGroup",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
