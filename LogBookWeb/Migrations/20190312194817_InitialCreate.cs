using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBookWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    name = table.Column<string>(maxLength: 64, nullable: true),
                    FacultyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_groups_faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    firstName = table.Column<string>(maxLength: 64, nullable: true),
                    lastName = table.Column<string>(maxLength: 64, nullable: true),
                    GroupId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "faculties",
                columns: new[] { "Id", "name" },
                values: new object[,]
                {
                    { new Guid("00aed207-c831-4cb1-bdb5-815794da4427"), "Programming" },
                    { new Guid("97cdace3-a2a1-4bb5-bb55-8423e73dfce7"), "System administration and security" },
                    { new Guid("8128d163-d737-4831-b7fc-cf266a7b2f54"), "Disign" },
                    { new Guid("148fe329-1968-4674-8060-81f79a5f55f2"), "Base" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_groups_FacultyId",
                table: "groups",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_students_GroupId",
                table: "students",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "faculties");
        }
    }
}
