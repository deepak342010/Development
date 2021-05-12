using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialMighration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblProcess",
                columns: table => new
                {
                    ProcessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VcProcessName = table.Column<string>(nullable: true),
                    IN_LAST_SEQ = table.Column<int>(nullable: false),
                    InLastupdatedBy = table.Column<int>(nullable: false),
                    DtLastupdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProcess", x => x.ProcessId);
                });

            migrationBuilder.CreateTable(
                name: "TblQueue",
                columns: table => new
                {
                    QueueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueueName = table.Column<string>(nullable: true),
                    TblProcess = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblQueue", x => x.QueueId);
                    table.ForeignKey(
                        name: "FK_TblQueue_TblProcess_TblProcess",
                        column: x => x.TblProcess,
                        principalTable: "TblProcess",
                        principalColumn: "ProcessId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblQueue_TblProcess",
                table: "TblQueue",
                column: "TblProcess");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "TblQueue");

            migrationBuilder.DropTable(
                name: "TblProcess");
        }
    }
}
