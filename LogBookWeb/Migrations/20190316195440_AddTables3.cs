using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBookWeb.Migrations
{
    public partial class AddTables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_marks_TeacherSubjects_TeacherSubjectId",
                table: "marks");

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
                name: "TeacherSubgectId",
                table: "marks");

            migrationBuilder.AlterColumn<Guid>(
                name: "TeacherSubjectId",
                table: "marks",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("33676bde-7055-4cb6-b5b6-b2f36365a3f0"), "Programming" },
                    { new Guid("e3a52eb7-647d-4539-b75b-16233f57098b"), "System administration and security" },
                    { new Guid("d7439330-9457-4f5c-887e-f3c34f15624b"), "Disign" },
                    { new Guid("0726d4c1-62da-4ac6-9034-078b8c388d69"), "Base" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_marks_TeacherSubjects_TeacherSubjectId",
                table: "marks",
                column: "TeacherSubjectId",
                principalTable: "TeacherSubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_marks_TeacherSubjects_TeacherSubjectId",
                table: "marks");

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("0726d4c1-62da-4ac6-9034-078b8c388d69"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("33676bde-7055-4cb6-b5b6-b2f36365a3f0"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("d7439330-9457-4f5c-887e-f3c34f15624b"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("e3a52eb7-647d-4539-b75b-16233f57098b"));

            migrationBuilder.AlterColumn<Guid>(
                name: "TeacherSubjectId",
                table: "marks",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherSubgectId",
                table: "marks",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_marks_TeacherSubjects_TeacherSubjectId",
                table: "marks",
                column: "TeacherSubjectId",
                principalTable: "TeacherSubjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
