using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazineWebApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeToInvoices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_EmployeeId",
                table: "Invoices",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_EmployeeId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Invoices");
        }
    }
}
