using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeuLibrary.Infrastructure.Migrations
{
    public partial class addedIsReservedcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Book",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Book");
        }
    }
}
