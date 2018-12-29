using Microsoft.EntityFrameworkCore.Migrations;

namespace Kredek.Db.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "ContactEntitis",
                newName: "IsActive");

            migrationBuilder.AddColumn<string>(
                name: "NewNew",
                table: "ContactEntitis",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewNew",
                table: "ContactEntitis");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "ContactEntitis",
                newName: "isActive");
        }
    }
}
