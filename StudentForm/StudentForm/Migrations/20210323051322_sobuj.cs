using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentForm.Migrations
{
    public partial class sobuj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StudentName = table.Column<string>(maxLength: 50, nullable: false),
                    FatherName = table.Column<string>(maxLength: 50, nullable: false),
                    MotherName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: false),
                    Religious = table.Column<string>(maxLength: 50, nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    PresentAddress = table.Column<string>(maxLength: 200, nullable: false),
                    PermanentAddress = table.Column<string>(maxLength: 200, nullable: false),
                    Qualification = table.Column<string>(nullable: false),
                    CourseApplied = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
