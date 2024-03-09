using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eRegister.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SchoolCode = table.Column<string>(type: "TEXT", nullable: false),
                    DepartmentCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProgrammeCode = table.Column<string>(type: "TEXT", nullable: false),
                    CourseCode = table.Column<string>(type: "TEXT", nullable: false),
                    SIN = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAttended = table.Column<string>(type: "TEXT", nullable: false),
                    IsPresent = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SIN = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Firstname = table.Column<string>(type: "TEXT", nullable: false),
                    Middlename = table.Column<string>(type: "TEXT", nullable: false),
                    Lastname = table.Column<string>(type: "TEXT", nullable: false),
                    ProgCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProgDescription = table.Column<string>(type: "TEXT", nullable: false),
                    DeviceAddress = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SIN);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
