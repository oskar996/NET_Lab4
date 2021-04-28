﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NET_Lab4.Migrations
{
    public partial class Migracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytuł = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataWydania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gatunek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Platforma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
