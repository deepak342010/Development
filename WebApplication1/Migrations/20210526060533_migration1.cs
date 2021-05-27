using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_CATCHWORD",
                columns: table => new
                {
                    IN_CATCHWORD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IN_TYPE = table.Column<int>(type: "int", nullable: false),
                    VC_CATCHWORD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_PROMPT = table.Column<bool>(type: "bit", nullable: false),
                    TI_CATCHWORD_ORDER = table.Column<int>(type: "int", nullable: false),
                    IN_LASTUPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    DT_LASTUPDATED_ON = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CATCHWORD", x => x.IN_CATCHWORD_ID);
                });

            migrationBuilder.CreateTable(
                name: "TblProcess",
                columns: table => new
                {
                    IN_PROCESS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VC_PROCESS_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IN_LAST_SEQ = table.Column<int>(type: "int", nullable: false),
                    IN_LASTUPDATED_By = table.Column<int>(type: "int", nullable: false),
                    DT_LASTUPDATED_ON = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProcess", x => x.IN_PROCESS_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_CATEGORY",
                columns: table => new
                {
                    IN_CATEGORY_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IN_PROCESS_ID = table.Column<int>(type: "int", nullable: false),
                    VC_CATEGORY_NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IN_SEQUENCE = table.Column<int>(type: "int", nullable: false),
                    B_PROMPT = table.Column<bool>(type: "bit", nullable: false),
                    IN_LASTUPDATED_BY = table.Column<int>(type: "int", nullable: false),
                    DT_LASTUPDATED_ON = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_CATEGORY", x => x.IN_CATEGORY_ID);
                    table.ForeignKey(
                        name: "FK_TBL_CATEGORY_TblProcess_IN_PROCESS_ID",
                        column: x => x.IN_PROCESS_ID,
                        principalTable: "TblProcess",
                        principalColumn: "IN_PROCESS_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblQueue",
                columns: table => new
                {
                    IN_QUEUE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VC_QUEUE_NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IN_PROCESS_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblQueue", x => x.IN_QUEUE_ID);
                    table.ForeignKey(
                        name: "FK_TblQueue_TblProcess_IN_PROCESS_ID",
                        column: x => x.IN_PROCESS_ID,
                        principalTable: "TblProcess",
                        principalColumn: "IN_PROCESS_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CATEGORY_IN_PROCESS_ID",
                table: "TBL_CATEGORY",
                column: "IN_PROCESS_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TblQueue_IN_PROCESS_ID",
                table: "TblQueue",
                column: "IN_PROCESS_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_CATCHWORD");

            migrationBuilder.DropTable(
                name: "TBL_CATEGORY");

            migrationBuilder.DropTable(
                name: "TblQueue");

            migrationBuilder.DropTable(
                name: "TblProcess");
        }
    }
}
