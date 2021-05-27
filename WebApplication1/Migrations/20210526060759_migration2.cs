using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CATEGORY_TblProcess_IN_PROCESS_ID",
                table: "TBL_CATEGORY");

            migrationBuilder.DropForeignKey(
                name: "FK_TblQueue_TblProcess_IN_PROCESS_ID",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess");

            migrationBuilder.RenameTable(
                name: "TblQueue",
                newName: "TBL_QUEUE");

            migrationBuilder.RenameTable(
                name: "TblProcess",
                newName: "TBL_PROESS");

            migrationBuilder.RenameIndex(
                name: "IX_TblQueue_IN_PROCESS_ID",
                table: "TBL_QUEUE",
                newName: "IX_TBL_QUEUE_IN_PROCESS_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_QUEUE",
                table: "TBL_QUEUE",
                column: "IN_QUEUE_ID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_CATEGORY_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_CATEGORY");

            migrationBuilder.DropForeignKey(
                name: "FK_TBL_QUEUE_TBL_PROESS_IN_PROCESS_ID",
                table: "TBL_QUEUE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_QUEUE",
                table: "TBL_QUEUE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_PROESS",
                table: "TBL_PROESS");

            migrationBuilder.RenameTable(
                name: "TBL_QUEUE",
                newName: "TblQueue");

            migrationBuilder.RenameTable(
                name: "TBL_PROESS",
                newName: "TblProcess");

            migrationBuilder.RenameIndex(
                name: "IX_TBL_QUEUE_IN_PROCESS_ID",
                table: "TblQueue",
                newName: "IX_TblQueue_IN_PROCESS_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue",
                column: "IN_QUEUE_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess",
                column: "IN_PROCESS_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_CATEGORY_TblProcess_IN_PROCESS_ID",
                table: "TBL_CATEGORY",
                column: "IN_PROCESS_ID",
                principalTable: "TblProcess",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblQueue_TblProcess_IN_PROCESS_ID",
                table: "TblQueue",
                column: "IN_PROCESS_ID",
                principalTable: "TblProcess",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
