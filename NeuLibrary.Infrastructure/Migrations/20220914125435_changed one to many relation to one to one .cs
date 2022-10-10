using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeuLibrary.Infrastructure.Migrations
{
    public partial class changedonetomanyrelationtoonetoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reserve_BookId",
                table: "Reserve");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Reserve");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Book",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_BookId",
                table: "Reserve",
                column: "BookId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reserve_BookId",
                table: "Reserve");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Book");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Reserve",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserve_BookId",
                table: "Reserve",
                column: "BookId");
        }
    }
}
