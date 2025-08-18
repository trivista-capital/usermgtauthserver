using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trivister.DataStore.Migrations
{
    /// <inheritdoc />
    public partial class makeEmailConfirmednotconpulsory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0834d4fc-a976-4428-b6f8-d47b832fad1a"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "516087f4-f3f3-422b-ae79-7d886721e59f", new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6152), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "9a66d806-bbb7-46fc-9e22-09037edb262b", new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6144), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6145) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("bcf0f8de-c8c3-44ee-9c67-df972d604cf2"),
                columns: new[] { "ConcurrencyStamp", "CreatedOn", "LastModified" },
                values: new object[] { "03ae7874-1c9b-4557-86d9-0dead18f539b", new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6157), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("3e7d9440-48d7-4174-b9c5-0ea5be7d9e7d"), new Guid("363b37a0-c306-4472-a405-4b576334cca0") },
                column: "LastModified",
                value: new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("363b37a0-c306-4472-a405-4b576334cca0"),
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedOn", "Email", "FirstName", "LastModified", "LastName", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "Address", "0785c65c-dba6-4c13-857b-25514be0beec", new DateTime(2024, 4, 29, 16, 18, 29, 313, DateTimeKind.Utc).AddTicks(8784), "tgslimited@gmail.com", "Admin", new DateTime(2024, 4, 29, 16, 18, 29, 313, DateTimeKind.Utc).AddTicks(8785), "Admin", "TGSLIMITED@GMAIL.COM", "AQAAAAEAACcQAAAAEJt7f+Xc2lzkS2yKUpMbsVlSoNz9lRU7i3b3Os2hI8inDB3qkfY2BEA0AqhNwHq5cQ==", "tgslimited@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5696), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5697), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5698), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5701), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5703), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5705), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5706), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5707), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5708), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5708), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5709), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5712), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5712) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "LastModified" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5713), new DateTime(2024, 4, 29, 16, 18, 29, 315, DateTimeKind.Utc).AddTicks(5713) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

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
                columns: new[] { "Address", "ConcurrencyStamp", "CreatedOn", "Email", "FirstName", "LastModified", "LastName", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "No sangotedo street aajah", "bf00ff08-0b86-42f4-915c-ecef6a356a12", new DateTime(2023, 8, 11, 15, 23, 51, 40, DateTimeKind.Utc).AddTicks(70), "femi.ibitolu@gmail.com", "Babafemi", new DateTime(2023, 8, 11, 15, 23, 51, 40, DateTimeKind.Utc).AddTicks(70), "Ibitolu", "FEMI.IBITOLU@GMAIL.COM", "AQAAAAEAACcQAAAAEKQDEjTqULEzQqDKbQMfVllLeyb7KGiLQE0PYhZBVUJlu6OobkUg9RzaJa3mGfkdXg==", "femi.ibitolu@gmail.com" });

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
    }
}
