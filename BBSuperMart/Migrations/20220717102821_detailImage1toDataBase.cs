using Microsoft.EntityFrameworkCore.Migrations;

namespace BBSuperMart.Migrations
{
    public partial class detailImage1toDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailImages1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailImages1",
                table: "Products");
        }
    }
}
