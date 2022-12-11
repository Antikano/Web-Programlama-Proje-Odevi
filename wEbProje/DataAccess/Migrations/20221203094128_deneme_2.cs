using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class deneme_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YazarID",
                table: "Kitaps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Yazar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarTanım = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazarResim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazar", x => x.YazarID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_YazarID",
                table: "Kitaps",
                column: "YazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaps_Yazar_YazarID",
                table: "Kitaps",
                column: "YazarID",
                principalTable: "Yazar",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaps_Yazar_YazarID",
                table: "Kitaps");

            migrationBuilder.DropTable(
                name: "Yazar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaps_YazarID",
                table: "Kitaps");

            migrationBuilder.DropColumn(
                name: "YazarID",
                table: "Kitaps");
        }
    }
}
