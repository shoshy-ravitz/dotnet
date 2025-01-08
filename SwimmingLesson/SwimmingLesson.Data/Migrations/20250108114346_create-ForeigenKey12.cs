using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeigenKey12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons");

            migrationBuilder.AlterColumn<int>(
                name: "GroupCodeGroup",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "GroupCodeGroup",
                table: "Lessons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_group_GroupCodeGroup",
                table: "Lessons",
                column: "GroupCodeGroup",
                principalTable: "group",
                principalColumn: "CodeGroup");
        }
    }
}
