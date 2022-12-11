using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class deneme_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaps_Yazar_YazarID",
                table: "Kitaps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazar",
                table: "Yazar");

            migrationBuilder.RenameTable(
                name: "Yazar",
                newName: "Yazars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazars",
                table: "Yazars",
                column: "YazarID");

            migrationBuilder.CreateTable(
                name: "Kategoris",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoris", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "KategoriKitap",
                columns: table => new
                {
                    KategorilerKategoriID = table.Column<int>(type: "int", nullable: false),
                    KitaplarKitapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriKitap", x => new { x.KategorilerKategoriID, x.KitaplarKitapID });
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kategoris_KategorilerKategoriID",
                        column: x => x.KategorilerKategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriKitap_Kitaps_KitaplarKitapID",
                        column: x => x.KitaplarKitapID,
                        principalTable: "Kitaps",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KategoriKitap_KitaplarKitapID",
                table: "KategoriKitap",
                column: "KitaplarKitapID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaps_Yazars_YazarID",
                table: "Kitaps",
                column: "YazarID",
                principalTable: "Yazars",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaps_Yazars_YazarID",
                table: "Kitaps");

            migrationBuilder.DropTable(
                name: "KategoriKitap");

            migrationBuilder.DropTable(
                name: "Kategoris");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazars",
                table: "Yazars");

            migrationBuilder.RenameTable(
                name: "Yazars",
                newName: "Yazar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazar",
                table: "Yazar",
                column: "YazarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaps_Yazar_YazarID",
                table: "Kitaps",
                column: "YazarID",
                principalTable: "Yazar",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
