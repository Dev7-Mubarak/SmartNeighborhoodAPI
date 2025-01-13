using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class amma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "623ea2a9-1df8-4b37-8bc2-1e9fe6fb9e8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bee62820-f815-46fa-b0c5-25b1f32cee53");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dbeed243-d2e2-4133-82d1-9da0f61934be", "b24eb599-97bf-4836-a4d3-9cd8dba0d59a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbeed243-d2e2-4133-82d1-9da0f61934be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b24eb599-97bf-4836-a4d3-9cd8dba0d59a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1069e95f-4c0c-4b76-bbf2-59991a613882", "faf33d13-7c0b-4acd-8439-8e1f2a850685", "BlockManager", "BLOCKMANAGER" },
                    { "93375850-adcc-43ef-8308-c80694d32357", "39e0751a-48fc-4bd2-a9c4-d972035f62a2", "User", "USER" },
                    { "c4d5d364-3754-4cd9-88b7-745c4cf92e59", "ec494e70-bff4-421c-af5a-ea3ea8009e8a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9dc97b73-41d3-4678-bd75-23069b0e263c", 0, "f27bb203-3dc3-443a-8460-768033287b8f", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAECZsYWTI6wfFvFBcOS21PjmM0fEbAbU9WZgqAHUuyVZmR5TQUsoE2MPRlbIR4OtJZg==", null, false, "b6f1463a-03d7-4d3e-ba6e-c1ea9c0ddf95", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c4d5d364-3754-4cd9-88b7-745c4cf92e59", "9dc97b73-41d3-4678-bd75-23069b0e263c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1069e95f-4c0c-4b76-bbf2-59991a613882");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93375850-adcc-43ef-8308-c80694d32357");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4d5d364-3754-4cd9-88b7-745c4cf92e59", "9dc97b73-41d3-4678-bd75-23069b0e263c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4d5d364-3754-4cd9-88b7-745c4cf92e59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dc97b73-41d3-4678-bd75-23069b0e263c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "623ea2a9-1df8-4b37-8bc2-1e9fe6fb9e8d", "800f93b2-e7ff-41b1-861f-d04277425ebf", "BlockManager", "BLOCKMANAGER" },
                    { "bee62820-f815-46fa-b0c5-25b1f32cee53", "3e041771-4f25-465f-b6a8-19a13edf203d", "User", "USER" },
                    { "dbeed243-d2e2-4133-82d1-9da0f61934be", "801b827b-4f86-42b0-95cc-7b2bf814a5b6", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b24eb599-97bf-4836-a4d3-9cd8dba0d59a", 0, "422f5cfd-36fd-43be-b8d3-fbadbd3d4a03", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEEzLNvvykaDZq1ZNW/fY9cCKwZ0M4cVP5XnXmpswZ4nFiyBGmMs0dHy8plGoZgbcEA==", null, false, "e48500da-4adf-4ce9-b5e1-8dd1981d35a4", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dbeed243-d2e2-4133-82d1-9da0f61934be", "b24eb599-97bf-4836-a4d3-9cd8dba0d59a" });
        }
    }
}
