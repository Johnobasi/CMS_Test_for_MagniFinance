using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class ModifiedObjectsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummary_Courses_CourseID",
                table: "CMSSummary");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummary_Students_StudentID",
                table: "CMSSummary");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummary_Subjects_SubjectID",
                table: "CMSSummary");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummary_Teachers_TeacherID",
                table: "CMSSummary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CMSSummary",
                table: "CMSSummary");

            migrationBuilder.RenameTable(
                name: "CMSSummary",
                newName: "CMSSummaries");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummary_TeacherID",
                table: "CMSSummaries",
                newName: "IX_CMSSummaries_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummary_SubjectID",
                table: "CMSSummaries",
                newName: "IX_CMSSummaries_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummary_StudentID",
                table: "CMSSummaries",
                newName: "IX_CMSSummaries_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummary_CourseID",
                table: "CMSSummaries",
                newName: "IX_CMSSummaries_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CMSSummaries",
                table: "CMSSummaries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummaries_Courses_CourseID",
                table: "CMSSummaries",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummaries_Students_StudentID",
                table: "CMSSummaries",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummaries_Subjects_SubjectID",
                table: "CMSSummaries",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummaries_Teachers_TeacherID",
                table: "CMSSummaries",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummaries_Courses_CourseID",
                table: "CMSSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummaries_Students_StudentID",
                table: "CMSSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummaries_Subjects_SubjectID",
                table: "CMSSummaries");

            migrationBuilder.DropForeignKey(
                name: "FK_CMSSummaries_Teachers_TeacherID",
                table: "CMSSummaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CMSSummaries",
                table: "CMSSummaries");

            migrationBuilder.RenameTable(
                name: "CMSSummaries",
                newName: "CMSSummary");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummaries_TeacherID",
                table: "CMSSummary",
                newName: "IX_CMSSummary_TeacherID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummaries_SubjectID",
                table: "CMSSummary",
                newName: "IX_CMSSummary_SubjectID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummaries_StudentID",
                table: "CMSSummary",
                newName: "IX_CMSSummary_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_CMSSummaries_CourseID",
                table: "CMSSummary",
                newName: "IX_CMSSummary_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CMSSummary",
                table: "CMSSummary",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummary_Courses_CourseID",
                table: "CMSSummary",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummary_Students_StudentID",
                table: "CMSSummary",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummary_Subjects_SubjectID",
                table: "CMSSummary",
                column: "SubjectID",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CMSSummary_Teachers_TeacherID",
                table: "CMSSummary",
                column: "TeacherID",
                principalTable: "Teachers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
