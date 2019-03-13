using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogBookWeb.Migrations
{
    public partial class AddModelsCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("00aed207-c831-4cb1-bdb5-815794da4427"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("148fe329-1968-4674-8060-81f79a5f55f2"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("8128d163-d737-4831-b7fc-cf266a7b2f54"));

            migrationBuilder.DeleteData(
                table: "faculties",
                keyColumn: "Id",
                keyValue: new Guid("97cdace3-a2a1-4bb5-bb55-8423e73dfce7"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
