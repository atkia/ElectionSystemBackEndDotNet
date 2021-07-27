using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ServerApp.Migrations
{
    public partial class candidateInfotable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates");

            migrationBuilder.RenameTable(
                name: "Candidates",
                newName: "CandidateInfos");

            migrationBuilder.AddColumn<string>(
                name: "ElectionName",
                table: "CandidateInfos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateInfos",
                table: "CandidateInfos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateInfos",
                table: "CandidateInfos");

            migrationBuilder.DropColumn(
                name: "ElectionName",
                table: "CandidateInfos");

            migrationBuilder.RenameTable(
                name: "CandidateInfos",
                newName: "Candidates");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates",
                column: "id");
        }
    }
}
