using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazineWebApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceToWholesale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WholesaleId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_WholesaleId",
                table: "Invoices",
                column: "WholesaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Wholesales_WholesaleId",
                table: "Invoices",
                column: "WholesaleId",
                principalTable: "Wholesales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Wholesales_WholesaleId",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_WholesaleId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "WholesaleId",
                table: "Invoices");
        }
    }
}
