using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBookWeb.Migrations
{
    public partial class AddTables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_groups_GroupId",
                table: "students");

            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("45e77b39-ccf4-47a0-859c-745df83929b8"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("afd50e45-4aed-402f-8c32-572d873a51e2"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("de9fba0f-61c7-488d-bb81-c5cd842dbe27"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("ec698e6a-2fff-4745-8722-d6fbad815614"));

            migrationBuilder.AddColumn<Guid>(
                name: "DepartmentId",
                table: "teachers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "students",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FacultytId",
                table: "groups",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSubjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TeacherId = table.Column<Guid>(nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSubjects_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    value = table.Column<string>(maxLength: 64, nullable: true),
                    StudentId = table.Column<Guid>(nullable: false),
                    TeacherSubgectId = table.Column<Guid>(nullable: false),
                    TeacherSubjectId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_marks_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_marks_TeacherSubjects_TeacherSubjectId",
                        column: x => x.TeacherSubjectId,
                        principalTable: "TeacherSubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("3c0671d7-db96-4774-b6c2-2d58099c33fa"), "Programming" },
                    { new Guid("3f781f36-bd47-4094-b757-7afae6ab50c1"), "System administration and security" },
                    { new Guid("6365439f-4ad8-4301-9c9f-2f49abba1c7e"), "Disign" },
                    { new Guid("b24da985-6fc1-436c-bece-b6bd28a5f155"), "Base" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_teachers_DepartmentId",
                table: "teachers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_marks_StudentId",
                table: "marks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_marks_TeacherSubjectId",
                table: "marks",
                column: "TeacherSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_SubjectId",
                table: "TeacherSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSubjects_TeacherId",
                table: "TeacherSubjects",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_groups_GroupId",
                table: "students",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_teachers_departments_DepartmentId",
                table: "teachers",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_groups_GroupId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_teachers_departments_DepartmentId",
                table: "teachers");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "marks");

            migrationBuilder.DropTable(
                name: "TeacherSubjects");

            migrationBuilder.DropTable(
                name: "subjects");

            migrationBuilder.DropIndex(
                name: "IX_teachers_DepartmentId",
                table: "teachers");

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("3c0671d7-db96-4774-b6c2-2d58099c33fa"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("3f781f36-bd47-4094-b757-7afae6ab50c1"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("6365439f-4ad8-4301-9c9f-2f49abba1c7e"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("b24da985-6fc1-436c-bece-b6bd28a5f155"));

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "teachers");

            migrationBuilder.DropColumn(
                name: "FacultytId",
                table: "groups");

            migrationBuilder.AlterColumn<Guid>(
                name: "GroupId",
                table: "students",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AcademicSubjectId = table.Column<Guid>(nullable: false),
                    rating = table.Column<string>(nullable: true),
                    created_at = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ratings_academic_subjects_AcademicSubjectId",
                        column: x => x.AcademicSubjectId,
                        principalTable: "academic_subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("afd50e45-4aed-402f-8c32-572d873a51e2"), "Programming" },
                    { new Guid("de9fba0f-61c7-488d-bb81-c5cd842dbe27"), "System administration and security" },
                    { new Guid("ec698e6a-2fff-4745-8722-d6fbad815614"), "Disign" },
                    { new Guid("45e77b39-ccf4-47a0-859c-745df83929b8"), "Base" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ratings_AcademicSubjectId",
                table: "ratings",
                column: "AcademicSubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_groups_GroupId",
                table: "students",
                column: "GroupId",
                principalTable: "groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
