using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBookWeb.Migrations
{
    public partial class AddModelsUpdateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("08fca569-889f-4a36-9bba-c7a2336cb99e"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("0bea97e5-59b9-4337-bd68-3cee2519f66e"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("1763eb18-5f4e-4763-b812-0e799e7c9e2d"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("82281005-1c9d-4d36-9388-0ecdf4701174"));

            migrationBuilder.CreateTable(
                name: "teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    firstName = table.Column<string>(maxLength: 64, nullable: true),
                    lastName = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "academic_subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    title = table.Column<string>(maxLength: 64, nullable: true),
                    TeacherId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_academic_subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_academic_subjects_teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ratings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    rating = table.Column<string>(nullable: true),
                    created_at = table.Column<string>(nullable: true),
                    AcademicSubjectId = table.Column<Guid>(nullable: false)
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
                name: "IX_academic_subjects_TeacherId",
                table: "academic_subjects",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ratings_AcademicSubjectId",
                table: "ratings",
                column: "AcademicSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ratings");

            migrationBuilder.DropTable(
                name: "academic_subjects");

            migrationBuilder.DropTable(
                name: "teachers");

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

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("08fca569-889f-4a36-9bba-c7a2336cb99e"), "Programming" },
                    { new Guid("0bea97e5-59b9-4337-bd68-3cee2519f66e"), "System administration and security" },
                    { new Guid("1763eb18-5f4e-4763-b812-0e799e7c9e2d"), "Disign" },
                    { new Guid("82281005-1c9d-4d36-9388-0ecdf4701174"), "Base" }
                });
        }
    }
}
