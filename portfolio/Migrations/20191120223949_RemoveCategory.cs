using Microsoft.EntityFrameworkCore.Migrations;

namespace portfolio.Migrations
{
    public partial class RemoveCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "BlogPosts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "BlogPosts",
                nullable: false,
                defaultValue: 0);
        }
    }
}
