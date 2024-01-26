using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogWalker_Blazor.Migrations
{
    /// <inheritdoc />
    public partial class fix_customer_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Customers_CustomerId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_CustomerId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Dogs");

            migrationBuilder.AlterColumn<string>(
                name: "customer_id",
                table: "Dogs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_customer_id",
                table: "Dogs",
                column: "customer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Customers_customer_id",
                table: "Dogs",
                column: "customer_id",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Customers_customer_id",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_customer_id",
                table: "Dogs");

            migrationBuilder.AlterColumn<string>(
                name: "customer_id",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Dogs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_CustomerId",
                table: "Dogs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Customers_CustomerId",
                table: "Dogs",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
