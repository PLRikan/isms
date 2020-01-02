using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ismsapi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    NameFirst = table.Column<string>(nullable: true),
                    NameMiddle = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DateSend = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MajorLectures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShortCode = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorLectures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleActions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Action = table.Column<string>(nullable: true),
                    ShortCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleActions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TutionStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutionStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventStatusId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventStatuses_EventStatusId",
                        column: x => x.EventStatusId,
                        principalTable: "EventStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MajorStudents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacultyId = table.Column<int>(nullable: false),
                    ShortCode = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajorStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MajorStudents_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleGroupId = table.Column<int>(nullable: false),
                    RoleActionId = table.Column<int>(nullable: false),
                    Allow = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleDetails_RoleActions_RoleActionId",
                        column: x => x.RoleActionId,
                        principalTable: "RoleActions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleDetails_RoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdmins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleGroupId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    NameFirst = table.Column<string>(nullable: true),
                    NameMiddle = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAdmins_RoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacultyId = table.Column<int>(nullable: false),
                    EducateTypeId = table.Column<int>(nullable: false),
                    StudyTypeId = table.Column<int>(nullable: false),
                    StudyStatusId = table.Column<int>(nullable: false),
                    RoleGroupId = table.Column<int>(nullable: false),
                    MajorLecturerId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    NameFirst = table.Column<string>(nullable: true),
                    NameMiddle = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true),
                    AddressApartment = table.Column<string>(nullable: true),
                    AddressStreet = table.Column<string>(nullable: true),
                    AddressDistrict = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    AddressCountry = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: true),
                    DateGraduate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectures_EducateTypes_EducateTypeId",
                        column: x => x.EducateTypeId,
                        principalTable: "EducateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lectures_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lectures_MajorLectures_MajorLecturerId",
                        column: x => x.MajorLecturerId,
                        principalTable: "MajorLectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lectures_RoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lectures_StudyStatuses_StudyStatusId",
                        column: x => x.StudyStatusId,
                        principalTable: "StudyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lectures_StudyTypes_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TutionStatus = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    TutionDebt = table.Column<int>(nullable: false),
                    TutionStatusNavigationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankAccounts_TutionStatuses_TutionStatusNavigationId",
                        column: x => x.TutionStatusNavigationId,
                        principalTable: "TutionStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EventBookings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EventId = table.Column<int>(nullable: false),
                    NameFirst = table.Column<string>(nullable: true),
                    NameMiddle = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventBookings_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminId = table.Column<int>(nullable: false),
                    PostStatusId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Thumbnail = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    DateCreate = table.Column<DateTime>(nullable: true),
                    DateModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_UserAdmins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "UserAdmins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_PostStatuses_PostStatusId",
                        column: x => x.PostStatusId,
                        principalTable: "PostStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacultyId = table.Column<int>(nullable: false),
                    MajorStudentId = table.Column<int>(nullable: false),
                    BankAccountId = table.Column<int>(nullable: false),
                    EducateTypeId = table.Column<int>(nullable: false),
                    StudyTypeId = table.Column<int>(nullable: false),
                    StudyStatusId = table.Column<int>(nullable: false),
                    RoleGroupId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    StudentCode = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    NameFirst = table.Column<string>(nullable: true),
                    NameMiddle = table.Column<string>(nullable: true),
                    NameLast = table.Column<string>(nullable: true),
                    AddressApartment = table.Column<string>(nullable: true),
                    AddressStreet = table.Column<string>(nullable: true),
                    AddressDistrict = table.Column<string>(nullable: true),
                    AddressCity = table.Column<string>(nullable: true),
                    DateStart = table.Column<DateTime>(nullable: true),
                    DateEnd = table.Column<DateTime>(nullable: true),
                    DateGraduate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_BankAccounts_BankAccountId",
                        column: x => x.BankAccountId,
                        principalTable: "BankAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_EducateTypes_EducateTypeId",
                        column: x => x.EducateTypeId,
                        principalTable: "EducateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id"
                        //onDelete: ReferentialAction.Cascade
                        );
                    table.ForeignKey(
                        name: "FK_Students_MajorStudents_MajorStudentId",
                        column: x => x.MajorStudentId,
                        principalTable: "MajorStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_RoleGroups_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "RoleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudyStatuses_StudyStatusId",
                        column: x => x.StudyStatusId,
                        principalTable: "StudyStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_StudyTypes_StudyTypeId",
                        column: x => x.StudyTypeId,
                        principalTable: "StudyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccounts_TutionStatusNavigationId",
                table: "BankAccounts",
                column: "TutionStatusNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_EventBookings_EventId",
                table: "EventBookings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventStatusId",
                table: "Events",
                column: "EventStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_EducateTypeId",
                table: "Lectures",
                column: "EducateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_FacultyId",
                table: "Lectures",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_MajorLecturerId",
                table: "Lectures",
                column: "MajorLecturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_RoleGroupId",
                table: "Lectures",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_StudyStatusId",
                table: "Lectures",
                column: "StudyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_StudyTypeId",
                table: "Lectures",
                column: "StudyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MajorStudents_FacultyId",
                table: "MajorStudents",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AdminId",
                table: "Posts",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostStatusId",
                table: "Posts",
                column: "PostStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleActionId",
                table: "RoleDetails",
                column: "RoleActionId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDetails_RoleGroupId",
                table: "RoleDetails",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_BankAccountId",
                table: "Students",
                column: "BankAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_EducateTypeId",
                table: "Students",
                column: "EducateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MajorStudentId",
                table: "Students",
                column: "MajorStudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_RoleGroupId",
                table: "Students",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudyStatusId",
                table: "Students",
                column: "StudyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudyTypeId",
                table: "Students",
                column: "StudyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdmins_RoleGroupId",
                table: "UserAdmins",
                column: "RoleGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EventBookings");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "RoleDetails");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "MajorLectures");

            migrationBuilder.DropTable(
                name: "UserAdmins");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PostStatuses");

            migrationBuilder.DropTable(
                name: "RoleActions");

            migrationBuilder.DropTable(
                name: "BankAccounts");

            migrationBuilder.DropTable(
                name: "EducateTypes");

            migrationBuilder.DropTable(
                name: "MajorStudents");

            migrationBuilder.DropTable(
                name: "StudyStatuses");

            migrationBuilder.DropTable(
                name: "StudyTypes");

            migrationBuilder.DropTable(
                name: "EventStatuses");

            migrationBuilder.DropTable(
                name: "RoleGroups");

            migrationBuilder.DropTable(
                name: "TutionStatuses");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
