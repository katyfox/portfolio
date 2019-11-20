using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class BlogPostIdToGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_BlogPosts", "BlogPosts");
            migrationBuilder.DropColumn("Id", "BlogPosts");

            migrationBuilder.AddColumn<Guid>(
                "Id",
                "BlogPosts");

            migrationBuilder.AddPrimaryKey("PK_BlogPosts", "BlogPosts", "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey("PK_BlogPosts", "BlogPosts");
            migrationBuilder.DropColumn("Id", "BlogPosts");

            migrationBuilder.AddColumn<int>("Id", "BlogPosts");
            migrationBuilder.AddPrimaryKey("PK_BlogPosts", "BlogPosts", "Id");
        }
    }
}
