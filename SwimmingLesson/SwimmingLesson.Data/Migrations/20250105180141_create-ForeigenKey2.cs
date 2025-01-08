using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons");

            migrationBuilder.AddColumn<int>(
                name: "GroupCodeGroup",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup",
                principalTable: "group",
                principalColumn: "CodeGroup",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons",
                column: "CodeGroup");

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
