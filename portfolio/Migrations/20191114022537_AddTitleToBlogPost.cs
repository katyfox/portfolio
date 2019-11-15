﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class AddTitleToBlogPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "BlogPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "BlogPosts");
        }
    }
}
