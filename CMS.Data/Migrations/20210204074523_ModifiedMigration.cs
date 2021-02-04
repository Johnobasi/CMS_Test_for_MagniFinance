using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Data.Migrations
{
    public partial class ModifiedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Courses_CourseID",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_CourseID",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SubjectId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubjectId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Grades",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentGrades",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Students",
                newName: "Grades");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Courses",
                newName: "ID");

            migrationBuilder.CreateTable(
                name: "CMSSummary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    SubjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSSummary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CMSSummary_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummary_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummary_Subjects_SubjectID",
                        column: x => x.SubjectID,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CMSSummary_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummary_CourseID",
                table: "CMSSummary",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummary_StudentID",
                table: "CMSSummary",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummary_SubjectID",
                table: "CMSSummary",
                column: "SubjectID");

            migrationBuilder.CreateIndex(
                name: "IX_CMSSummary_TeacherID",
                table: "CMSSummary",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CMSSummary");

            migrationBuilder.RenameColumn(
                name: "Grades",
                table: "Students",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Courses",
                newName: "CourseID");

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grades",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGrades",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_CourseID",
                table: "Teachers",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SubjectId",
                table: "Teachers",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseID",
                table: "Students",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubjectId",
                table: "Students",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Subjects_SubjectId",
                table: "Students",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Courses_CourseID",
                table: "Teachers",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Subjects_SubjectId",
                table: "Teachers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
