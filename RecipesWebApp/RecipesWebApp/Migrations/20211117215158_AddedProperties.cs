using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesWebApp.Migrations
{
    public partial class AddedProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Recipes",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageType",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ImageType",
                table: "Recipes");
        }
    }
}
