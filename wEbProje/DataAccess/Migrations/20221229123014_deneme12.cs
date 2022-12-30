using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class deneme12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YazarMail",
                table: "Yazars");

            migrationBuilder.DropColumn(
                name: "YazarResim",
                table: "Yazars");

            migrationBuilder.DropColumn(
                name: "YazarSifre",
                table: "Yazars");

            migrationBuilder.DropColumn(
                name: "YazarTanım",
                table: "Yazars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YazarMail",
                table: "Yazars",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YazarResim",
                table: "Yazars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YazarSifre",
                table: "Yazars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "YazarTanım",
                table: "Yazars",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }
    }
}
