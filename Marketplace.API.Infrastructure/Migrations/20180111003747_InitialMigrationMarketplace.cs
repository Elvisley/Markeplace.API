using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Marketplace.API.Infrastructure.Migrations
{
    public partial class InitialMigrationMarketplace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MARKETPLACE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ADDRESS = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    LOCATION_MAPS = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true),
                    NAME = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PHONE = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    PHOTO = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SOCIAL_REASON = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ID", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MARKETPLACE");
        }
    }
}
