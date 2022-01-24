using Microsoft.EntityFrameworkCore.Migrations;

namespace HOME_LOAN_BE.Migrations
{
    public partial class InitalMigration78 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer",
                table: "customer_Details",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Squestion",
                table: "customer_Details",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer",
                table: "customer_Details");

            migrationBuilder.DropColumn(
                name: "Squestion",
                table: "customer_Details");
        }
    }
}
