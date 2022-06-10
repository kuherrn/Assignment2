using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week5.Data.Migrations
{
    public partial class ProvinceDBUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Province");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Province",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
