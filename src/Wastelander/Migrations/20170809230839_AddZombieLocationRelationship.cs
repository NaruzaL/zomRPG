using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wastelander.Migrations
{
    public partial class AddZombieLocationRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Zombies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Zombies_LocationId",
                table: "Zombies",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zombies_Locations_LocationId",
                table: "Zombies",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zombies_Locations_LocationId",
                table: "Zombies");

            migrationBuilder.DropIndex(
                name: "IX_Zombies_LocationId",
                table: "Zombies");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Zombies");
        }
    }
}
