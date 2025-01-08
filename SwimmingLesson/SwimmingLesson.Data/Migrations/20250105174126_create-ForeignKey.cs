using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwimmingLesson.Data.Migrations
{
    public partial class createForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeCourse",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CodeGroup",
                table: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStartLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeEndLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "CodeStudent",
                table: "group",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KindSwim",
                table: "course",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CourseGuide",
                columns: table => new
                {
                    CoursesCodeCourse = table.Column<int>(type: "int", nullable: false),
                    guidesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGuide", x => new { x.CoursesCodeCourse, x.guidesId });
                    table.ForeignKey(
                        name: "FK_CourseGuide_course_CoursesCodeCourse",
                        column: x => x.CoursesCodeCourse,
                        principalTable: "course",
                        principalColumn: "CodeCourse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseGuide_Guides_guidesId",
                        column: x => x.guidesId,
                        principalTable: "Guides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupStudent",
                columns: table => new
                {
                    GroupsCodeGroup = table.Column<int>(type: "int", nullable: false),
                    StudentsCodeStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => new { x.GroupsCodeGroup, x.StudentsCodeStudent });
                    table.ForeignKey(
                        name: "FK_GroupStudent_group_GroupsCodeGroup",
                        column: x => x.GroupsCodeGroup,
                        principalTable: "group",
                        principalColumn: "CodeGroup",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Students_StudentsCodeStudent",
                        column: x => x.StudentsCodeStudent,
                        principalTable: "Students",
                        principalColumn: "CodeStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons",
                column: "CodeGroup");

            migrationBuilder.CreateIndex(
                name: "IX_group_CodeCourse",
                table: "group",
                column: "CodeCourse");

            migrationBuilder.CreateIndex(
                name: "IX_group_CodeGuide",
                table: "group",
                column: "CodeGuide");

            migrationBuilder.CreateIndex(
                name: "IX_CourseGuide_guidesId",
                table: "CourseGuide",
                column: "guidesId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_StudentsCodeStudent",
                table: "GroupStudent",
                column: "StudentsCodeStudent");

            migrationBuilder.AddForeignKey(
                name: "FK_group_course_CodeCourse",
                table: "group",
                column: "CodeCourse",
                principalTable: "course",
                principalColumn: "CodeCourse",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_group_Guides_CodeGuide",
                table: "group",
                column: "CodeGuide",
                principalTable: "Guides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_group_course_CodeCourse",
                table: "group");

            migrationBuilder.DropForeignKey(
                name: "FK_group_Guides_CodeGuide",
                table: "group");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_group_CodeGroup",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "CourseGuide");

            migrationBuilder.DropTable(
                name: "GroupStudent");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CodeGroup",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_group_CodeCourse",
                table: "group");

            migrationBuilder.DropIndex(
                name: "IX_group_CodeGuide",
                table: "group");

            migrationBuilder.DropColumn(
                name: "CodeStudent",
                table: "group");

            migrationBuilder.DropColumn(
                name: "KindSwim",
                table: "course");

            migrationBuilder.AddColumn<int>(
                name: "CodeCourse",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodeGroup",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeStartLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeEndLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateLesson",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
