using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class AmmarTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_BaseEntity_UserId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_BaseEntity_UserId1",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_People_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_People_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_Roles_RoleId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_Complains_BaseEntity_UserId",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_Complains_BaseEntity_UserId1",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonComplains_BaseEntity_UserId",
                table: "PersonComplains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44b63bee-af93-4f9c-b0e8-75851437432f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f0cf25d-c03e-4d81-beb3-b73a25421686");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0d17fe47-c1c5-49bd-b3d1-449639327055", "3aa0988d-3133-4486-b3ad-ca8788d5a37b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d17fe47-c1c5-49bd-b3d1-449639327055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aa0988d-3133-4486-b3ad-ca8788d5a37b");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PhoneType",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PhontNumber",
                table: "BaseEntity");

            migrationBuilder.RenameTable(
                name: "BaseEntity",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_BaseEntity_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ContactInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhontNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    PhoneType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactInfos_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactInfos_People_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_PersonId",
                table: "ContactInfos",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactInfos_PersonId1",
                table: "ContactInfos",
                column: "PersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Users_UserId",
                table: "Ads",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_Users_UserId1",
                table: "Ads",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_Users_UserId",
                table: "Complains",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_Users_UserId1",
                table: "Complains",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonComplains_Users_UserId",
                table: "PersonComplains",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Users_UserId",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Ads_Users_UserId1",
                table: "Ads");

            migrationBuilder.DropForeignKey(
                name: "FK_Complains_Users_UserId",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_Complains_Users_UserId1",
                table: "Complains");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonComplains_Users_UserId",
                table: "PersonComplains");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ContactInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

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

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "BaseEntity");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "BaseEntity",
                newName: "IX_BaseEntity_RoleId");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "BaseEntity",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "BaseEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BaseEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "BaseEntity",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BaseEntity",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType",
                table: "BaseEntity",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhontNumber",
                table: "BaseEntity",
                type: "nvarchar(9)",
                maxLength: 9,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntity",
                table: "BaseEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d17fe47-c1c5-49bd-b3d1-449639327055", "6642032a-a3af-4cbf-a6a6-d2178f6a6ee3", "Admin", "ADMIN" },
                    { "44b63bee-af93-4f9c-b0e8-75851437432f", "48b46dc6-7333-4cbd-9597-89e42f835f16", "User", "USER" },
                    { "7f0cf25d-c03e-4d81-beb3-b73a25421686", "55adc4f9-7ee9-4479-8244-8f2c9f053852", "BlockManager", "BLOCKMANAGER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3aa0988d-3133-4486-b3ad-ca8788d5a37b", 0, "b4fe1b18-75e2-4ccd-be1d-673351715552", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEKL4Sz/EitbXOeEZHHqluDhc9ceTfWO6qA4iLTbrxr5IPpdpx6JCdqaYlndiK2Ix7g==", null, false, "d700590c-4728-4a3a-b65f-860b074a1548", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0d17fe47-c1c5-49bd-b3d1-449639327055", "3aa0988d-3133-4486-b3ad-ca8788d5a37b" });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PersonId",
                table: "BaseEntity",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PersonId1",
                table: "BaseEntity",
                column: "PersonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_BaseEntity_UserId",
                table: "Ads",
                column: "UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ads_BaseEntity_UserId1",
                table: "Ads",
                column: "UserId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_People_PersonId",
                table: "BaseEntity",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_People_PersonId1",
                table: "BaseEntity",
                column: "PersonId1",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_Roles_RoleId",
                table: "BaseEntity",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_BaseEntity_UserId",
                table: "Complains",
                column: "UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Complains_BaseEntity_UserId1",
                table: "Complains",
                column: "UserId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonComplains_BaseEntity_UserId",
                table: "PersonComplains",
                column: "UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id");
        }
    }
}
