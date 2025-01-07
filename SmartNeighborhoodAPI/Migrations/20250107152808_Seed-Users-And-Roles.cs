using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class SeedUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07174f83-736d-42a1-90c0-fdbf8f253b39", "0c0df423-d27d-40ba-9485-db12f82ceacc", "User", "USER" },
                    { "b0076ca1-efbc-4cc2-8bc6-cac8cb67d14b", "35b2eb49-99cd-43da-973c-766e53e0438d", "BlockManager", "BLOCKMANAGER" },
                    { "b90cd34f-8f7c-47a5-a5f1-2d4e6bfbf634", "9012967e-95ff-4a02-b221-ebe8115c3e50", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e71ceede-7b13-4434-a242-a6f5044013f3", 0, "b5d98dd6-36ee-4696-a158-17228e8e689c", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEMGYEjGpaTnWlZY26oOlpllvSIFkWx2saPQk/4d/tQf/UjkRf6QuYjfWyJK0IG2uNg==", null, false, "8fd5e760-cff5-40ca-9e49-6e2d93d3bccb", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b90cd34f-8f7c-47a5-a5f1-2d4e6bfbf634", "e71ceede-7b13-4434-a242-a6f5044013f3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07174f83-736d-42a1-90c0-fdbf8f253b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0076ca1-efbc-4cc2-8bc6-cac8cb67d14b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b90cd34f-8f7c-47a5-a5f1-2d4e6bfbf634", "e71ceede-7b13-4434-a242-a6f5044013f3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90cd34f-8f7c-47a5-a5f1-2d4e6bfbf634");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e71ceede-7b13-4434-a242-a6f5044013f3");
        }
    }
}
