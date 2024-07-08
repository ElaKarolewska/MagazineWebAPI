using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazineWebApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MedicineToInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Invoice_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Medicines");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "InvoiceMedicine",
                columns: table => new
                {
                    InvoicesId = table.Column<int>(type: "int", nullable: false),
                    MedicinesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceMedicine", x => new { x.InvoicesId, x.MedicinesId });
                    table.ForeignKey(
                        name: "FK_InvoiceMedicine_Invoices_InvoicesId",
                        column: x => x.InvoicesId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceMedicine_Medicines_MedicinesId",
                        column: x => x.MedicinesId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceMedicine_MedicinesId",
                table: "InvoiceMedicine",
                column: "MedicinesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceMedicine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Invoice_InvoiceId",
                table: "Medicines",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
