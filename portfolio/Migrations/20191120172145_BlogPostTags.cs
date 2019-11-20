using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class BlogPostTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPostTags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostBlogPostTag",
                columns: table => new
                {
                    BlogPostId = table.Column<Guid>(nullable: false),
                    BlogPostTagId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostBlogPostTag", x => new { x.BlogPostId, x.BlogPostTagId });
                    table.ForeignKey(
                        name: "FK_BlogPostBlogPostTag_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogPostBlogPostTag_BlogPostTags_BlogPostTagId",
                        column: x => x.BlogPostTagId,
                        principalTable: "BlogPostTags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPostBlogPostTag_BlogPostTagId",
                table: "BlogPostBlogPostTag",
                column: "BlogPostTagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPostBlogPostTag");

            migrationBuilder.DropTable(
                name: "BlogPostTags");
        }
    }
}
