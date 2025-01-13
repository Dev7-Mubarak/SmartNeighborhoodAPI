using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartNeighborhoodAPI.Migrations
{
    public partial class SmartNeibourhood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ad_UserId = table.Column<int>(type: "int", nullable: true),
                    Ad_UserId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Block_UserId = table.Column<int>(type: "int", nullable: true),
                    Complain_UserId = table.Column<int>(type: "int", nullable: true),
                    UserId1 = table.Column<int>(type: "int", nullable: true),
                    Complain_Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Outcome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplainTypeId = table.Column<int>(type: "int", nullable: true),
                    SessionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsResolved = table.Column<byte>(type: "tinyint", nullable: true),
                    ComplainTypeId1 = table.Column<int>(type: "int", nullable: true),
                    PhontNumber = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    PhoneType = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ContactInfo_PersonId = table.Column<int>(type: "int", nullable: true),
                    ContactInfo_PersonId1 = table.Column<int>(type: "int", nullable: true),
                    FamilyCatgoryId = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FamilyTypeId = table.Column<int>(type: "int", nullable: true),
                    FamilyNotes = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Family_BlockId = table.Column<int>(type: "int", nullable: true),
                    FamilyCatgoryId1 = table.Column<int>(type: "int", nullable: true),
                    FamilyTypeId1 = table.Column<int>(type: "int", nullable: true),
                    FamilyMember_PersonId = table.Column<int>(type: "int", nullable: true),
                    FamilyMember_PersonId1 = table.Column<int>(type: "int", nullable: true),
                    FamilyMember_FamilyId = table.Column<int>(type: "int", nullable: true),
                    FamilyMember_FamilyId1 = table.Column<int>(type: "int", nullable: true),
                    MemberTypeId = table.Column<int>(type: "int", nullable: true),
                    AdId = table.Column<int>(type: "int", nullable: true),
                    MidName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TypeOfIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PesonId = table.Column<int>(type: "int", nullable: true),
                    PersonComplain_PersonId = table.Column<int>(type: "int", nullable: true),
                    ComplainId = table.Column<int>(type: "int", nullable: true),
                    ComplainId2 = table.Column<int>(type: "int", nullable: true),
                    ConfilctPartyId = table.Column<int>(type: "int", nullable: true),
                    ComplainId1 = table.Column<int>(type: "int", nullable: true),
                    ConfilctPartyId1 = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    ProjectCatgoryId = table.Column<int>(type: "int", nullable: true),
                    ProjectCatogoryId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Budget = table.Column<double>(type: "float", nullable: true),
                    Proiorty = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ProjectCatogoryId1 = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    ProjectFamily_ProjectId = table.Column<int>(type: "int", nullable: true),
                    ProjectId2 = table.Column<int>(type: "int", nullable: true),
                    FamilyId = table.Column<int>(type: "int", nullable: true),
                    FamilyId1 = table.Column<int>(type: "int", nullable: true),
                    BlockId = table.Column<int>(type: "int", nullable: true),
                    ProjectScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectFamily_ProjectId1 = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    ProjectId1 = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    TeamId1 = table.Column<int>(type: "int", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: true),
                    PersonId1 = table.Column<int>(type: "int", nullable: true),
                    DateOfJoin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MemberJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Ad_UserId",
                        column: x => x.Ad_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Ad_UserId1",
                        column: x => x.Ad_UserId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_AdId",
                        column: x => x.AdId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_BlockId",
                        column: x => x.BlockId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Complain_UserId",
                        column: x => x.Complain_UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ComplainId",
                        column: x => x.ComplainId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ComplainId1",
                        column: x => x.ComplainId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ComplainId2",
                        column: x => x.ComplainId2,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ComplainTypeId",
                        column: x => x.ComplainTypeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ComplainTypeId1",
                        column: x => x.ComplainTypeId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ConfilctPartyId",
                        column: x => x.ConfilctPartyId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ConfilctPartyId1",
                        column: x => x.ConfilctPartyId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId",
                        column: x => x.ContactInfo_PersonId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ContactInfo_PersonId1",
                        column: x => x.ContactInfo_PersonId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_Family_BlockId",
                        column: x => x.Family_BlockId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId",
                        column: x => x.FamilyCatgoryId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyCatgoryId1",
                        column: x => x.FamilyCatgoryId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyId",
                        column: x => x.FamilyId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyId1",
                        column: x => x.FamilyId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId",
                        column: x => x.FamilyMember_FamilyId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyMember_FamilyId1",
                        column: x => x.FamilyMember_FamilyId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId",
                        column: x => x.FamilyMember_PersonId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyMember_PersonId1",
                        column: x => x.FamilyMember_PersonId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyTypeId",
                        column: x => x.FamilyTypeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_FamilyTypeId1",
                        column: x => x.FamilyTypeId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_GroupId",
                        column: x => x.GroupId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_MemberTypeId",
                        column: x => x.MemberTypeId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PersonComplain_PersonId",
                        column: x => x.PersonComplain_PersonId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PersonId",
                        column: x => x.PersonId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId",
                        column: x => x.ProjectCatogoryId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectCatogoryId1",
                        column: x => x.ProjectCatogoryId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId",
                        column: x => x.ProjectFamily_ProjectId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectFamily_ProjectId1",
                        column: x => x.ProjectFamily_ProjectId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectId1",
                        column: x => x.ProjectId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ProjectId2",
                        column: x => x.ProjectId2,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_RoleId",
                        column: x => x.RoleId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_TeamId",
                        column: x => x.TeamId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserId",
                        column: x => x.UserId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_UserId1",
                        column: x => x.UserId1,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_BaseEntity_PersonId",
                table: "BaseEntity",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_PersonId1",
                table: "BaseEntity",
                column: "PersonId1");

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
                name: "IX_BaseEntity_RoleId",
                table: "BaseEntity",
                column: "RoleId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntity");

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
    }
}
