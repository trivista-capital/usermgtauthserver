using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trivister.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class chnageddefaultuserdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0834d4fc-a976-4428-b6f8-d47b832fad1a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "9d532a4e-ef53-405b-be96-88f4972eb90c", new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(3010), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "fdc25f67-f77e-4653-8fd4-68ee77eb2df9", new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(2970), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bcf0f8de-c8c3-44ee-9c67-df972d604cf2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "a857b889-7af7-4ca7-9481-f5ba5ccf8235", new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), new Guid("363b37a0-c306-4472-a405-4b576334cca0") },
                column: "LastModified",
                value: new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("363b37a0-c306-4472-a405-4b576334cca0"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified", "PasswordHash" },
                values: new object[] { "bf00ff08-0b86-42f4-915c-ecef6a356a12", new DateTime(2023, 8, 11, 15, 23, 51, 40, DateTimeKind.Utc).AddTicks(70), new DateTime(2023, 8, 11, 15, 23, 51, 40, DateTimeKind.Utc).AddTicks(70), "AQAAAAEAACcQAAAAEKQDEjTqULEzQqDKbQMfVllLeyb7KGiLQE0PYhZBVUJlu6OobkUg9RzaJa3mGfkdXg==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1500), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1500), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1540), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1550), new DateTime(2023, 8, 11, 15, 23, 51, 50, DateTimeKind.Utc).AddTicks(1550) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0834d4fc-a976-4428-b6f8-d47b832fad1a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "a11f82b5-d206-4648-825d-c1cb0d661f44", new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9820), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "0647a963-8f6c-4036-aa99-2553ecd7161c", new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bcf0f8de-c8c3-44ee-9c67-df972d604cf2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "97b7b4c2-6e4b-4815-8cd0-f2c30a832811", new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9830), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), new Guid("363b37a0-c306-4472-a405-4b576334cca0") },
                column: "LastModified",
                value: new DateTime(2023, 8, 11, 15, 9, 14, 224, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("363b37a0-c306-4472-a405-4b576334cca0"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified", "PasswordHash" },
                values: new object[] { "04a676cc-687d-42b3-8d80-7360d2769ba3", new DateTime(2023, 8, 11, 15, 9, 14, 218, DateTimeKind.Utc).AddTicks(7500), new DateTime(2023, 8, 11, 15, 9, 14, 218, DateTimeKind.Utc).AddTicks(7500), "AQAAAAEAACcQAAAAEJMZHt7RJ89w7IsWTAQnbOyu48QvO2HbAWIMr3kzbu8zy3BQb9IMnHOE/x8+Mti2mw==" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9170), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 8, 11, 15, 9, 14, 223, DateTimeKind.Utc).AddTicks(9210) });
        }
    }
}
