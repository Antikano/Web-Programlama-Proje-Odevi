using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class deneme5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yorums",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumBaslık = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KitapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorums", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorums_Kitaps_KitapID",
                        column: x => x.KitapID,
                        principalTable: "Kitaps",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yorums_KitapID",
                table: "Yorums",
                column: "KitapID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yorums");
        }
    }
}
