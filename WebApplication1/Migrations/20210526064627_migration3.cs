using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CATEGORY_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_CATEGORY");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_QUEUE_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_QUEUE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_PROESS",
                table: "TBL_PROESS");

            migrationBuilder.RenameTable(
                name: "TBL_PROESS",
                newName: "TBL_PROCESS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_PROCESS",
                table: "TBL_PROCESS",
                column: "IN_PROCESS_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CATEGORY_TBL_PROCESS_IN_PROCESS_ID",
                table: "TBL_CATEGORY",
                column: "IN_PROCESS_ID",
                principalTable: "TBL_PROCESS",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_QUEUE_TBL_PROCESS_IN_PROCESS_ID",
                table: "TBL_QUEUE",
                column: "IN_PROCESS_ID",
                principalTable: "TBL_PROCESS",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CATEGORY_TBL_PROCESS_IN_PROCESS_ID",
                table: "TBL_CATEGORY");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_QUEUE_TBL_PROCESS_IN_PROCESS_ID",
                table: "TBL_QUEUE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_PROCESS",
                table: "TBL_PROCESS");

            migrationBuilder.RenameTable(
                name: "TBL_PROCESS",
                newName: "TBL_PROESS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_PROESS",
                table: "TBL_PROESS",
                column: "IN_PROCESS_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CATEGORY_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_CATEGORY",
                column: "IN_PROCESS_ID",
                principalTable: "TBL_PROESS",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_QUEUE_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_QUEUE",
                column: "IN_PROCESS_ID",
                principalTable: "TBL_PROESS",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
