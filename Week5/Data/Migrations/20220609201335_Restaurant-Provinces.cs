using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week5.Data.Migrations
{
    public partial class RestaurantProvinces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Restaurant",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    operatingYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_ProvinceId",
                table: "Restaurant",
                column: "ProvinceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurant_Province_ProvinceId",
                table: "Restaurant",
                column: "ProvinceId",
                principalTable: "Province",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurant_Province_ProvinceId",
                table: "Restaurant");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropIndex(
                name: "IX_Restaurant_ProvinceId",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Restaurant");
        }
    }
}
