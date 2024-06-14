using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MihrapPlak.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AlbumSanatcisi_Grubu = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AlbumCikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AlbumFiyati = table.Column<decimal>(type: "money", nullable: false),
                    IndirimOrani = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Satistami = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.AlbumId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    KullaniciSoyAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "AlbumKullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumKullanicilar", x => new { x.AlbumId, x.KullaniciId });
                    table.ForeignKey(
                        name: "FK_AlbumKullanicilar_Albumler_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albumler",
                        principalColumn: "AlbumId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumKullanicilar_Users_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Users",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumKullanicilar_KullaniciId",
                table: "AlbumKullanicilar",
                column: "KullaniciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumKullanicilar");

            migrationBuilder.DropTable(
                name: "Albumler");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
