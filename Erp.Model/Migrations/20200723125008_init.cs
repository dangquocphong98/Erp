using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Erp.Model.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id_Staff = table.Column<string>(nullable: false),
                    AttendanceCode = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CodeMachine = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Birth = table.Column<DateTime>(nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    PassWord = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id_Staff);
                });

            migrationBuilder.CreateTable(
                name: "Timekeepers",
                columns: table => new
                {
                    CodeMachine = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timekeepers", x => x.CodeMachine);
                });

            migrationBuilder.CreateTable(
                name: "TimekeepingHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodeStaff = table.Column<string>(nullable: true),
                    CodeMachine = table.Column<string>(nullable: true),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    BackTime = table.Column<DateTime>(nullable: false),
                    IsTrue = table.Column<bool>(nullable: false),
                    LateTime = table.Column<int>(nullable: false),
                    LateTimeType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimekeepingHistories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Timekeepers");

            migrationBuilder.DropTable(
                name: "TimekeepingHistories");
        }
    }
}
