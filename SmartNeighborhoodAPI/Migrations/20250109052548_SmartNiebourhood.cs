using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class SmartNiebourhood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25ee3b7b-0928-4721-a656-fab218b03e9d", "218796a9-12a2-4c5c-b105-f5804c15c42d", "BlockManager", "BLOCKMANAGER" },
                    { "36ca24b6-2a56-4fb6-8e14-2550b8776dfa", "93ff8a85-8b2b-4773-9655-65420ee51087", "User", "USER" },
                    { "6e28176a-eaae-40c7-822c-cd8da6a0e036", "6554030f-1f6d-4a7a-836e-28b6463d1081", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c2085929-44ed-4df6-8df2-9a0ad6eff15b", 0, "1cce0107-b233-428d-a4bf-5e8361c8c667", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEA9R8351jfvXj5lCn47V1QVgvcMf+A9qcnUrFneHHlPLfPLV+EhG3TxqJWaM9zDrrw==", null, false, "a44841aa-59ae-4c15-8e5b-d9a6913bfc5c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6e28176a-eaae-40c7-822c-cd8da6a0e036", "c2085929-44ed-4df6-8df2-9a0ad6eff15b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ee3b7b-0928-4721-a656-fab218b03e9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36ca24b6-2a56-4fb6-8e14-2550b8776dfa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e28176a-eaae-40c7-822c-cd8da6a0e036", "c2085929-44ed-4df6-8df2-9a0ad6eff15b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e28176a-eaae-40c7-822c-cd8da6a0e036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2085929-44ed-4df6-8df2-9a0ad6eff15b");

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
    }
}
