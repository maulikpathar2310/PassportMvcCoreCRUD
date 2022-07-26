using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PassportMvcCoreCRUD.Migrations
{
    public partial class PassportCoreDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "s1",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    applying = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    re_reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ex_reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    other_reason1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    app_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    booklet_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    validity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s1", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s2",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    other_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    changes_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birth_state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_select = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marital_status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pan_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    voter_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emp_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emp_org_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gov_servant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edu_qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    non_ecr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mark_select = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aadhar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s2", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s3",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    father_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guardian_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guardian_middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guardian_surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spouse_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spouse_middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spouse_surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass_file = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_passport_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    father_nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_passport_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mother_nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s3", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s4",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    district = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    police_station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobile_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telephone_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    same_add = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s4", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s5",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    em_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    em_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    em_email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s5", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s6",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    certi_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    issue_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    expiry_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    issue_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    not_issued_pass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    file_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    month_year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pass_office = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s6", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s7",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    od1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od14_sub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    od15_sub = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s7", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s8",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    fee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dd_num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dd_issue_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dd_exp_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bank_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s8", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "s9",
                columns: table => new
                {
                    file_num = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    en_file = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sd_place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sd_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sd_sign = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s9", x => x.file_num);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "s1");

            migrationBuilder.DropTable(
                name: "s2");

            migrationBuilder.DropTable(
                name: "s3");

            migrationBuilder.DropTable(
                name: "s4");

            migrationBuilder.DropTable(
                name: "s5");

            migrationBuilder.DropTable(
                name: "s6");

            migrationBuilder.DropTable(
                name: "s7");

            migrationBuilder.DropTable(
                name: "s8");

            migrationBuilder.DropTable(
                name: "s9");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
