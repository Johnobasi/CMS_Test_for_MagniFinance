using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class refactoredDataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMSSummaries");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "Students",
                newName: "BirthdayDay");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthdayDay",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CourseManagementId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Teachers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Subjects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseManagementId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseManagements",
                columns: table => new
                {
                    CourseManagementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseManagements", x => x.CourseManagementId);
                    table.ForeignKey(
                        name: "FK_CourseManagements_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseManagementId",
                table: "Teachers",
                column: "CourseManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CourseID",
                table: "Subjects",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseManagementId",
                table: "Students",
                column: "CourseManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeacherID",
                table: "Students",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseManagements_CourseID",
                table: "CourseManagements",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_CourseManagements_CourseManagementId",
                table: "Students",
                column: "CourseManagementId",
                principalTable: "CourseManagements",
                principalColumn: "CourseManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Courses_CourseID",
                table: "Subjects",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_CourseManagements_CourseManagementId",
                table: "Teachers",
                column: "CourseManagementId",
                principalTable: "CourseManagements",
                principalColumn: "CourseManagementId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_CourseManagements_CourseManagementId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Courses_CourseID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Teachers_TeacherID",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_CourseManagements_CourseManagementId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "CourseManagements");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CourseManagementId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CourseID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_TeacherID",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseManagementId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeacherID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthdayDay",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CourseManagementId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeacherID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "BirthdayDay",
                table: "Students",
                newName: "RegistrationDate");

            migrationBuilder.CreateTable(
                name: "CMSSummaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSSummaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CMSSummaries_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummaries_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummaries_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummaries_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummaries_CourseID",
                table: "CMSSummaries",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummaries_StudentID",
                table: "CMSSummaries",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummaries_SubjectID",
                table: "CMSSummaries",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummaries_TeacherID",
                table: "CMSSummaries",
                column: "TeacherID");
        }
    }
}
