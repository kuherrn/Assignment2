using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week5.Data.Migrations
{
    public partial class LastOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "restaurantName",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "restaurantName",
                table: "Restaurant");
        }
    }
}
