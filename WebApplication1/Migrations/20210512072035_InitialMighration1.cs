using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialMighration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblQueue_TblProcess_TblProcess",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "QueueId",
                table: "TblQueue");

            migrationBuilder.DropColumn(
                name: "QueueName",
                table: "TblQueue");

            migrationBuilder.DropColumn(
                name: "ProcessId",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "DtLastupdatedOn",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "InLastupdatedBy",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "VcProcessName",
                table: "TblProcess");

            migrationBuilder.AddColumn<int>(
                name: "IN_QUEUE_ID",
                table: "TblQueue",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "VC_QUEUE_NAME",
                table: "TblQueue",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IN_PROCESS_ID",
                table: "TblProcess",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DT_LASTUPDATED_ON",
                table: "TblProcess",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IN_LASTUPDATED_By",
                table: "TblProcess",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VC_PROCESS_NAME",
                table: "TblProcess",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue",
                column: "IN_QUEUE_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess",
                column: "IN_PROCESS_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TblQueue_TblProcess_TblProcess",
                table: "TblQueue",
                column: "TblProcess",
                principalTable: "TblProcess",
                principalColumn: "IN_PROCESS_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblQueue_TblProcess_TblProcess",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "IN_QUEUE_ID",
                table: "TblQueue");

            migrationBuilder.DropColumn(
                name: "VC_QUEUE_NAME",
                table: "TblQueue");

            migrationBuilder.DropColumn(
                name: "IN_PROCESS_ID",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "DT_LASTUPDATED_ON",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "IN_LASTUPDATED_By",
                table: "TblProcess");

            migrationBuilder.DropColumn(
                name: "VC_PROCESS_NAME",
                table: "TblProcess");

            migrationBuilder.AddColumn<int>(
                name: "QueueId",
                table: "TblQueue",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "QueueName",
                table: "TblQueue",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcessId",
                table: "TblProcess",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtLastupdatedOn",
                table: "TblProcess",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InLastupdatedBy",
                table: "TblProcess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "VcProcessName",
                table: "TblProcess",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblQueue",
                table: "TblQueue",
                column: "QueueId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProcess",
                table: "TblProcess",
                column: "ProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblQueue_TblProcess_TblProcess",
                table: "TblQueue",
                column: "TblProcess",
                principalTable: "TblProcess",
                principalColumn: "ProcessId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
