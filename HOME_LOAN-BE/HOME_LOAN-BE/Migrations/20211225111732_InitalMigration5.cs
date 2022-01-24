using Microsoft.EntityFrameworkCore.Migrations;

namespace HOME_LOAN_BE.Migrations
{
    public partial class InitalMigration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_Details_appTables_AppTableid",
                table: "customer_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_Details_appTables_AppTableid",
                table: "employee_Details");

            migrationBuilder.DropForeignKey(
                name: "FK_loan_appTables_AppTableid",
                table: "loan");

            migrationBuilder.DropForeignKey(
                name: "FK_property_Details_appTables_AppTableid",
                table: "property_Details");

            migrationBuilder.DropTable(
                name: "appTables");

            migrationBuilder.DropIndex(
                name: "IX_property_Details_AppTableid",
                table: "property_Details");

            migrationBuilder.DropIndex(
                name: "IX_loan_AppTableid",
                table: "loan");

            migrationBuilder.DropIndex(
                name: "IX_employee_Details_AppTableid",
                table: "employee_Details");

            migrationBuilder.DropIndex(
                name: "IX_customer_Details_AppTableid",
                table: "customer_Details");

            migrationBuilder.DropColumn(
                name: "AppTableid",
                table: "property_Details");

            migrationBuilder.DropColumn(
                name: "AppTableid",
                table: "loan");

            migrationBuilder.DropColumn(
                name: "AppTableid",
                table: "employee_Details");

            migrationBuilder.DropColumn(
                name: "AppTableid",
                table: "customer_Details");

            migrationBuilder.CreateTable(
                name: "status_Details",
                columns: table => new
                {
                    statusid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(nullable: true),
                    amount = table.Column<float>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_Details", x => x.statusid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "status_Details");

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "property_Details",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "loan",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "employee_Details",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "customer_Details",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "appTables",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(type: "int", nullable: false),
                    Emp_ID = table.Column<int>(type: "int", nullable: false),
                    EstimatedAmount = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Propertyid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appTables", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_property_Details_AppTableid",
                table: "property_Details",
                column: "AppTableid");

            migrationBuilder.CreateIndex(
                name: "IX_loan_AppTableid",
                table: "loan",
                column: "AppTableid");

            migrationBuilder.CreateIndex(
                name: "IX_employee_Details_AppTableid",
                table: "employee_Details",
                column: "AppTableid");

            migrationBuilder.CreateIndex(
                name: "IX_customer_Details_AppTableid",
                table: "customer_Details",
                column: "AppTableid");

            migrationBuilder.AddForeignKey(
                name: "FK_customer_Details_appTables_AppTableid",
                table: "customer_Details",
                column: "AppTableid",
                principalTable: "appTables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_Details_appTables_AppTableid",
                table: "employee_Details",
                column: "AppTableid",
                principalTable: "appTables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_loan_appTables_AppTableid",
                table: "loan",
                column: "AppTableid",
                principalTable: "appTables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_property_Details_appTables_AppTableid",
                table: "property_Details",
                column: "AppTableid",
                principalTable: "appTables",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
