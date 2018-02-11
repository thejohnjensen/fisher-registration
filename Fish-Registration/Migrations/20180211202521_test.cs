using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FishRegistration.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaptainId",
                table: "Vessel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vessel_CaptainId",
                table: "Vessel",
                column: "CaptainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vessel_Captain_CaptainId",
                table: "Vessel",
                column: "CaptainId",
                principalTable: "Captain",
                principalColumn: "CaptainId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vessel_Captain_CaptainId",
                table: "Vessel");

            migrationBuilder.DropIndex(
                name: "IX_Vessel_CaptainId",
                table: "Vessel");

            migrationBuilder.DropColumn(
                name: "CaptainId",
                table: "Vessel");
        }
    }
}
