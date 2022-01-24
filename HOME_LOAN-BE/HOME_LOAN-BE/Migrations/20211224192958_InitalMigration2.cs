using Microsoft.EntityFrameworkCore.Migrations;

namespace HOME_LOAN_BE.Migrations
{
    public partial class InitalMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "property_Details",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "loan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "employee_Details",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "customer_Details",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Middle_Name",
                table: "customer_Details",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "customer_Details",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "customer_Details",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email_id",
                table: "customer_Details",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppTableid",
                table: "customer_Details",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "appTables",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_id = table.Column<int>(nullable: false),
                    Emp_ID = table.Column<int>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    PropertyLocation = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    EstimatedAmount = table.Column<int>(nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "customer_Details",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Middle_Name",
                table: "customer_Details",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_Name",
                table: "customer_Details",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "customer_Details",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email_id",
                table: "customer_Details",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
