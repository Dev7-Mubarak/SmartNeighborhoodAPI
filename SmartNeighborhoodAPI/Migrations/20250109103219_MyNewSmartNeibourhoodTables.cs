using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class MyNewSmartNeibourhoodTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_Ad_UserId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_Ad_UserId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_AdId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_BlockId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_Complain_UserId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId2",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainTypeId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ConfilctPartyId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ConfilctPartyId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_Family_BlockId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyTypeId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_GroupId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_MemberTypeId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonComplain_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId2",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_RoleId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_TeamId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_TeamId1",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_UserId",
                table: "BaseEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseEntity_BaseEntity_UserId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_Ad_UserId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_Ad_UserId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_AdId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_BlockId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_Complain_UserId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ComplainId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ComplainId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ComplainId2",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ComplainTypeId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ComplainTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ConfilctPartyId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ConfilctPartyId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ContactInfo_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ContactInfo_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_Family_BlockId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyCatgoryId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyCatgoryId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyMember_FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyMember_FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyMember_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyMember_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyTypeId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_FamilyTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_GroupId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_MemberTypeId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_PersonComplain_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectCatogoryId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectCatogoryId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectFamily_ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectFamily_ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_ProjectId2",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_TeamId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_TeamId1",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity");

            migrationBuilder.DropIndex(
                name: "IX_BaseEntity_UserId1",
                table: "BaseEntity");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28fa473b-318b-4cf1-9929-12e859214ddb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "545686d6-eddf-4309-8379-995d5822484d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f48732e7-0ba4-4b9a-a4a4-e9551ced1447", "bdd69930-2e7f-498e-8be0-39f1817f5f6d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f48732e7-0ba4-4b9a-a4a4-e9551ced1447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bdd69930-2e7f-498e-8be0-39f1817f5f6d");

            migrationBuilder.DropColumn(
                name: "AdId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Ad_UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Ad_UserId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "BlockId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Block_UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Budget",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ComplainId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ComplainId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ComplainId2",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ComplainTypeId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ComplainTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Complain_Image",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Complain_UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ConfilctPartyId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ConfilctPartyId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ContactInfo_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ContactInfo_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "DateOfJoin",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyCatgoryId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyCatgoryId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyMember_FamilyId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyMember_FamilyId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyMember_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyMember_PersonId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyNotes",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyTypeId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "FamilyTypeId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Family_BlockId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "IdentityNumber",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "IsResolved",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MemberJob",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MemberTypeId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "MidName",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Outcome",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PersonComplain_PersonId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "PesonId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Proiorty",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectCatgoryId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectCatogoryId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectCatogoryId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectFamily_ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectFamily_ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectId2",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectScope",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ProjectStatus",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "SessionDate",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "TeamId1",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "TypeOfIdentity",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "BaseEntity");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BaseEntity",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplainTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplainTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfilctParties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfilctParties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyCatgories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyCatgories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FamilyType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MidName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<byte>(type: "tinyint", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TypeOfIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCatogories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectCatogories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplainTypeId = table.Column<int>(type: "int", nullable: false),
                    SessionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsResolved = table.Column<byte>(type: "tinyint", nullable: false),
                    ComplainTypeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complains_BaseEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complains_BaseEntity_UserId1",
                        column: x => x.UserId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complains_ComplainTypes_ComplainTypeId",
                        column: x => x.ComplainTypeId,
                        principalTable: "ComplainTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Complains_ComplainTypes_ComplainTypeId1",
                        column: x => x.ComplainTypeId1,
                        principalTable: "ComplainTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyCatgoryId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FamilyTypeId = table.Column<int>(type: "int", nullable: false),
                    FamilyNotes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    FamilyCatgoryId1 = table.Column<int>(type: "int", nullable: true),
                    FamilyTypeId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Families_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_FamilyCatgories_FamilyCatgoryId",
                        column: x => x.FamilyCatgoryId,
                        principalTable: "FamilyCatgories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_FamilyCatgories_FamilyCatgoryId1",
                        column: x => x.FamilyCatgoryId1,
                        principalTable: "FamilyCatgories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Families_FamilyType_FamilyTypeId",
                        column: x => x.FamilyTypeId,
                        principalTable: "FamilyType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Families_FamilyType_FamilyTypeId1",
                        column: x => x.FamilyTypeId1,
                        principalTable: "FamilyType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    ProjectCatgoryId = table.Column<int>(type: "int", nullable: false),
                    ProjectCatogoryId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget = table.Column<double>(type: "float", nullable: true),
                    Proiorty = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProjectCatogoryId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectCatogories_ProjectCatogoryId",
                        column: x => x.ProjectCatogoryId,
                        principalTable: "ProjectCatogories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_ProjectCatogories_ProjectCatogoryId1",
                        column: x => x.ProjectCatogoryId1,
                        principalTable: "ProjectCatogories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonComplains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PesonId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ComplainId = table.Column<int>(type: "int", nullable: false),
                    ComplainId2 = table.Column<int>(type: "int", nullable: false),
                    ConfilctPartyId = table.Column<int>(type: "int", nullable: false),
                    ComplainId1 = table.Column<int>(type: "int", nullable: true),
                    ConfilctPartyId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonComplains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonComplains_BaseEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonComplains_Complains_ComplainId1",
                        column: x => x.ComplainId1,
                        principalTable: "Complains",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonComplains_Complains_ComplainId2",
                        column: x => x.ComplainId2,
                        principalTable: "Complains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonComplains_ConfilctParties_ConfilctPartyId",
                        column: x => x.ConfilctPartyId,
                        principalTable: "ConfilctParties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonComplains_ConfilctParties_ConfilctPartyId1",
                        column: x => x.ConfilctPartyId1,
                        principalTable: "ConfilctParties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PersonComplains_People_ComplainId",
                        column: x => x.ComplainId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonComplains_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false),
                    FamilyId1 = table.Column<int>(type: "int", nullable: false),
                    MemberTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_Families_FamilyId1",
                        column: x => x.FamilyId1,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_MemberTypes_MemberTypeId",
                        column: x => x.MemberTypeId,
                        principalTable: "MemberTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyMembers_People_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFamilies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectId2 = table.Column<int>(type: "int", nullable: false),
                    FamilyId = table.Column<int>(type: "int", nullable: false),
                    FamilyId1 = table.Column<int>(type: "int", nullable: false),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    ProjectScope = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFamilies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Blocks_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Families_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Families_FamilyId1",
                        column: x => x.FamilyId1,
                        principalTable: "Families",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Projects_ProjectId1",
                        column: x => x.ProjectId1,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectFamilies_Projects_ProjectId2",
                        column: x => x.ProjectId2,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectId1",
                        column: x => x.ProjectId1,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    TeamId1 = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    PersonId1 = table.Column<int>(type: "int", nullable: false),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_People_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserId1 = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ads_BaseEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_BaseEntity_UserId1",
                        column: x => x.UserId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "Id");
                });

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
                name: "IX_Ads_GroupId",
                table: "Ads",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_UserId",
                table: "Ads",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_UserId1",
                table: "Ads",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_ComplainTypeId",
                table: "Complains",
                column: "ComplainTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_ComplainTypeId1",
                table: "Complains",
                column: "ComplainTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_UserId",
                table: "Complains",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Complains_UserId1",
                table: "Complains",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Families_BlockId",
                table: "Families",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_FamilyCatgoryId",
                table: "Families",
                column: "FamilyCatgoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_FamilyCatgoryId1",
                table: "Families",
                column: "FamilyCatgoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Families_FamilyTypeId",
                table: "Families",
                column: "FamilyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Families_FamilyTypeId1",
                table: "Families",
                column: "FamilyTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_FamilyId",
                table: "FamilyMembers",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_FamilyId1",
                table: "FamilyMembers",
                column: "FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_MemberTypeId",
                table: "FamilyMembers",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_PersonId",
                table: "FamilyMembers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyMembers_PersonId1",
                table: "FamilyMembers",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_AdId",
                table: "Groups",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_ComplainId",
                table: "PersonComplains",
                column: "ComplainId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_ComplainId1",
                table: "PersonComplains",
                column: "ComplainId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_ComplainId2",
                table: "PersonComplains",
                column: "ComplainId2");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_ConfilctPartyId",
                table: "PersonComplains",
                column: "ConfilctPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_ConfilctPartyId1",
                table: "PersonComplains",
                column: "ConfilctPartyId1");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_PersonId",
                table: "PersonComplains",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonComplains_UserId",
                table: "PersonComplains",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_BlockId",
                table: "ProjectFamilies",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_FamilyId",
                table: "ProjectFamilies",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_FamilyId1",
                table: "ProjectFamilies",
                column: "FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_ProjectId",
                table: "ProjectFamilies",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_ProjectId1",
                table: "ProjectFamilies",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFamilies_ProjectId2",
                table: "ProjectFamilies",
                column: "ProjectId2");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCatogoryId",
                table: "Projects",
                column: "ProjectCatogoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectCatogoryId1",
                table: "Projects",
                column: "ProjectCatogoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_PersonId",
                table: "TeamMembers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_PersonId1",
                table: "TeamMembers",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId1",
                table: "TeamMembers",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId",
                table: "Teams",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ProjectId1",
                table: "Teams",
                column: "ProjectId1");

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
                name: "FK_Ads_Groups_GroupId",
                table: "Ads",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Ads_Groups_GroupId",
                table: "Ads");

            migrationBuilder.DropTable(
                name: "FamilyMembers");

            migrationBuilder.DropTable(
                name: "PersonComplains");

            migrationBuilder.DropTable(
                name: "ProjectFamilies");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropTable(
                name: "Complains");

            migrationBuilder.DropTable(
                name: "ConfilctParties");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "ComplainTypes");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "FamilyCatgories");

            migrationBuilder.DropTable(
                name: "FamilyType");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "ProjectCatogories");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Ads");

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BaseEntity",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "AdId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ad_UserId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ad_UserId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BlockId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Block_UserId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "BaseEntity",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Budget",
                table: "BaseEntity",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComplainId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComplainId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComplainId2",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComplainTypeId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComplainTypeId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Complain_Image",
                table: "BaseEntity",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Complain_UserId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfilctPartyId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConfilctPartyId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactInfo_PersonId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactInfo_PersonId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfJoin",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "BaseEntity",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyCatgoryId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyCatgoryId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyMember_FamilyId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyMember_FamilyId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyMember_PersonId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyMember_PersonId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyNotes",
                table: "BaseEntity",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyTypeId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FamilyTypeId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Family_BlockId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Gender",
                table: "BaseEntity",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentityNumber",
                table: "BaseEntity",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "BaseEntity",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "IsResolved",
                table: "BaseEntity",
                type: "tinyint",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "BaseEntity",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "BaseEntity",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberJob",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemberTypeId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MidName",
                table: "BaseEntity",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Outcome",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonComplain_PersonId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PesonId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Proiorty",
                table: "BaseEntity",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectCatgoryId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectCatogoryId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectCatogoryId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectFamily_ProjectId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectFamily_ProjectId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId2",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectScope",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectStatus",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SessionDate",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "BaseEntity",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "BaseEntity",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeOfIdentity",
                table: "BaseEntity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "BaseEntity",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28fa473b-318b-4cf1-9929-12e859214ddb", "d53c16ef-a8c6-4eb7-9ea1-8a42114220bc", "BlockManager", "BLOCKMANAGER" },
                    { "545686d6-eddf-4309-8379-995d5822484d", "35066eb5-4d03-4621-9158-7b5cf1a4cd1c", "User", "USER" },
                    { "f48732e7-0ba4-4b9a-a4a4-e9551ced1447", "389be331-91fc-4c50-b5a0-88f35ca4cad7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bdd69930-2e7f-498e-8be0-39f1817f5f6d", 0, "556be184-9469-40ea-b078-215c2e8676f9", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAENKqvm6OcY4htK5pl8Yu7YWA+DZwNNJfw7EzLq/fCC8ltCuH7zBBTC0q/B/aTuP9Lg==", null, false, "e8372dc8-27f0-44d7-ba3f-dbb451859cdd", false, "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f48732e7-0ba4-4b9a-a4a4-e9551ced1447", "bdd69930-2e7f-498e-8be0-39f1817f5f6d" });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Ad_UserId",
                table: "BaseEntity",
                column: "Ad_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Ad_UserId1",
                table: "BaseEntity",
                column: "Ad_UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_AdId",
                table: "BaseEntity",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_BlockId",
                table: "BaseEntity",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Complain_UserId",
                table: "BaseEntity",
                column: "Complain_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ComplainId",
                table: "BaseEntity",
                column: "ComplainId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ComplainId1",
                table: "BaseEntity",
                column: "ComplainId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ComplainId2",
                table: "BaseEntity",
                column: "ComplainId2");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ComplainTypeId",
                table: "BaseEntity",
                column: "ComplainTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ComplainTypeId1",
                table: "BaseEntity",
                column: "ComplainTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ConfilctPartyId",
                table: "BaseEntity",
                column: "ConfilctPartyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ConfilctPartyId1",
                table: "BaseEntity",
                column: "ConfilctPartyId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ContactInfo_PersonId",
                table: "BaseEntity",
                column: "ContactInfo_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ContactInfo_PersonId1",
                table: "BaseEntity",
                column: "ContactInfo_PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_Family_BlockId",
                table: "BaseEntity",
                column: "Family_BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyCatgoryId",
                table: "BaseEntity",
                column: "FamilyCatgoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyCatgoryId1",
                table: "BaseEntity",
                column: "FamilyCatgoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyId",
                table: "BaseEntity",
                column: "FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyId1",
                table: "BaseEntity",
                column: "FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyMember_FamilyId",
                table: "BaseEntity",
                column: "FamilyMember_FamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyMember_FamilyId1",
                table: "BaseEntity",
                column: "FamilyMember_FamilyId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyMember_PersonId",
                table: "BaseEntity",
                column: "FamilyMember_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyMember_PersonId1",
                table: "BaseEntity",
                column: "FamilyMember_PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyTypeId",
                table: "BaseEntity",
                column: "FamilyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_FamilyTypeId1",
                table: "BaseEntity",
                column: "FamilyTypeId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_GroupId",
                table: "BaseEntity",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_MemberTypeId",
                table: "BaseEntity",
                column: "MemberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PersonComplain_PersonId",
                table: "BaseEntity",
                column: "PersonComplain_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectCatogoryId",
                table: "BaseEntity",
                column: "ProjectCatogoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectCatogoryId1",
                table: "BaseEntity",
                column: "ProjectCatogoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectFamily_ProjectId",
                table: "BaseEntity",
                column: "ProjectFamily_ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectFamily_ProjectId1",
                table: "BaseEntity",
                column: "ProjectFamily_ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectId",
                table: "BaseEntity",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectId1",
                table: "BaseEntity",
                column: "ProjectId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ProjectId2",
                table: "BaseEntity",
                column: "ProjectId2");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_TeamId",
                table: "BaseEntity",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_TeamId1",
                table: "BaseEntity",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserId",
                table: "BaseEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_UserId1",
                table: "BaseEntity",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_Ad_UserId",
                table: "BaseEntity",
                column: "Ad_UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_Ad_UserId1",
                table: "BaseEntity",
                column: "Ad_UserId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_AdId",
                table: "BaseEntity",
                column: "AdId",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_BlockId",
                table: "BaseEntity",
                column: "BlockId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_Complain_UserId",
                table: "BaseEntity",
                column: "Complain_UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId",
                table: "BaseEntity",
                column: "ComplainId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId1",
                table: "BaseEntity",
                column: "ComplainId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainId2",
                table: "BaseEntity",
                column: "ComplainId2",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainTypeId",
                table: "BaseEntity",
                column: "ComplainTypeId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ComplainTypeId1",
                table: "BaseEntity",
                column: "ComplainTypeId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ConfilctPartyId",
                table: "BaseEntity",
                column: "ConfilctPartyId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ConfilctPartyId1",
                table: "BaseEntity",
                column: "ConfilctPartyId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId",
                table: "BaseEntity",
                column: "ContactInfo_PersonId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId1",
                table: "BaseEntity",
                column: "ContactInfo_PersonId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_Family_BlockId",
                table: "BaseEntity",
                column: "Family_BlockId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId",
                table: "BaseEntity",
                column: "FamilyCatgoryId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId1",
                table: "BaseEntity",
                column: "FamilyCatgoryId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyId",
                table: "BaseEntity",
                column: "FamilyId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyId1",
                table: "BaseEntity",
                column: "FamilyId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId",
                table: "BaseEntity",
                column: "FamilyMember_FamilyId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId1",
                table: "BaseEntity",
                column: "FamilyMember_FamilyId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId",
                table: "BaseEntity",
                column: "FamilyMember_PersonId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId1",
                table: "BaseEntity",
                column: "FamilyMember_PersonId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyTypeId",
                table: "BaseEntity",
                column: "FamilyTypeId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_FamilyTypeId1",
                table: "BaseEntity",
                column: "FamilyTypeId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_GroupId",
                table: "BaseEntity",
                column: "GroupId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_MemberTypeId",
                table: "BaseEntity",
                column: "MemberTypeId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonComplain_PersonId",
                table: "BaseEntity",
                column: "PersonComplain_PersonId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonId",
                table: "BaseEntity",
                column: "PersonId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_PersonId1",
                table: "BaseEntity",
                column: "PersonId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId",
                table: "BaseEntity",
                column: "ProjectCatogoryId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId1",
                table: "BaseEntity",
                column: "ProjectCatogoryId1",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId",
                table: "BaseEntity",
                column: "ProjectFamily_ProjectId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId1",
                table: "BaseEntity",
                column: "ProjectFamily_ProjectId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId",
                table: "BaseEntity",
                column: "ProjectId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId1",
                table: "BaseEntity",
                column: "ProjectId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_ProjectId2",
                table: "BaseEntity",
                column: "ProjectId2",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_RoleId",
                table: "BaseEntity",
                column: "RoleId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_TeamId",
                table: "BaseEntity",
                column: "TeamId",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_TeamId1",
                table: "BaseEntity",
                column: "TeamId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_UserId",
                table: "BaseEntity",
                column: "UserId",
                principalTable: "BaseEntity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BaseEntity_BaseEntity_UserId1",
                table: "BaseEntity",
                column: "UserId1",
                principalTable: "BaseEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
