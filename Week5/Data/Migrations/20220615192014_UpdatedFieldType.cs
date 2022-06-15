using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week5.Data.Migrations
{
    public partial class UpdatedFieldType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "foodPrice",
                table: "Restaurant",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "foodPrice",
                table: "Restaurant",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
