using Microsoft.EntityFrameworkCore.Migrations;

namespace МоитеГуми.Data.Migrations
{
    public partial class gg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Обяви");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Обяви",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
