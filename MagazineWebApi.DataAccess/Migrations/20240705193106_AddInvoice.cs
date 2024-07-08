using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagazineWebApi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddInvoice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Medicines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Invoice_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_InvoiceId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Medicines");
        }
    }
}
