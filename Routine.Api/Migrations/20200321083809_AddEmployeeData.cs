using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Routine.Api.Migrations
{
    public partial class AddEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("0a552c81-ea2a-426c-8bfb-9e2a7b7960b1"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("cb6aa237-2d0a-4369-a941-6e84e177c392"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("f5bd9965-f72a-4511-b736-877876b824d0"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), "Great Compnay", "Microsoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("6fb600c1-9011-4fd7-9234-881379716440"), "Don't be evil", "Google" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("5efc910b-2f45-43df-afae-620d40542853"), "Fubao Company", "Alipapa" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT231", "Nick", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"), new Guid("bbdee09c-089b-4d30-bece-44df5923716c"), new DateTime(1981, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MSFT245", "Vince", 1, "Carter" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("72457e73-ea34-4e02-b575-8d384e82a481"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1986, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "G003", "Mary", 2, "King" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"), new Guid("6fb600c1-9011-4fd7-9234-881379716440"), new DateTime(1977, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "G097", "Kevin", 1, "Richardson" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1967, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "A009", "卡", 2, "里" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "DateOfBirth", "EmployeeNo", "FirstName", "Gender", "LastName" },
                values: new object[] { new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"), new Guid("5efc910b-2f45-43df-afae-620d40542853"), new DateTime(1957, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A404", "Not", 1, "Man" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1861341e-b42b-410c-ae21-cf11f36fc574"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4b501cb3-d168-4cc0-b375-48fb33f318a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("679dfd33-32e4-4393-b061-f7abb8956f53"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("72457e73-ea34-4e02-b575-8d384e82a481"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7644b71d-d74e-43e2-ac32-8cbadd7b1c3a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7eaa532c-1be5-472c-a738-94fd26e5fad6"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("5efc910b-2f45-43df-afae-620d40542853"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("6fb600c1-9011-4fd7-9234-881379716440"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: new Guid("bbdee09c-089b-4d30-bece-44df5923716c"));

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("cb6aa237-2d0a-4369-a941-6e84e177c392"), "Great Compnay", "Microsoft" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("f5bd9965-f72a-4511-b736-877876b824d0"), "Don't be evil", "Google" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Introduction", "Name" },
                values: new object[] { new Guid("0a552c81-ea2a-426c-8bfb-9e2a7b7960b1"), "Fubao Company", "Alipapa" });
        }
    }
}
