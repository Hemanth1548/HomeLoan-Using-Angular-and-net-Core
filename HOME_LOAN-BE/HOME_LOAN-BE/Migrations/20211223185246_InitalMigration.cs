using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HOME_LOAN_BE.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin_Details",
                columns: table => new
                {
                    AdminUsername = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_Details", x => x.AdminUsername);
                });

            migrationBuilder.CreateTable(
                name: "customer_Details",
                columns: table => new
                {
                    Customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Middle_Name = table.Column<string>(maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email_id = table.Column<string>(maxLength: 50, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Confirm_Password = table.Column<string>(nullable: false),
                    Phone_No = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Aadhar_No = table.Column<string>(nullable: true),
                    Pan_No = table.Column<string>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_Details", x => x.Customer_id);
                });

            migrationBuilder.CreateTable(
                name: "employee_Details",
                columns: table => new
                {
                    Emp_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type_of_Employment = table.Column<string>(nullable: true),
                    Retirement_Age = table.Column<int>(nullable: false),
                    Organisation_Type = table.Column<string>(nullable: true),
                    Employee_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_Details", x => x.Emp_ID);
                });

            migrationBuilder.CreateTable(
                name: "loan",
                columns: table => new
                {
                    Loan_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Max_Loan_Amt = table.Column<float>(nullable: false),
                    ROI = table.Column<float>(nullable: false),
                    Tenure = table.Column<int>(nullable: false),
                    Loan_Amt = table.Column<float>(nullable: false),
                    Propertyid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loan", x => x.Loan_id);
                });

            migrationBuilder.CreateTable(
                name: "property_Details",
                columns: table => new
                {
                    Propertyid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyLocation = table.Column<string>(nullable: true),
                    PropertyName = table.Column<string>(nullable: true),
                    EstimatedAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_property_Details", x => x.Propertyid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin_Details");

            migrationBuilder.DropTable(
                name: "customer_Details");

            migrationBuilder.DropTable(
                name: "employee_Details");

            migrationBuilder.DropTable(
                name: "loan");

            migrationBuilder.DropTable(
                name: "property_Details");
        }
    }
}
