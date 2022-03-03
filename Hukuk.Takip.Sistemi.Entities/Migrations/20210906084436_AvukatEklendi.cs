using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class AvukatEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avukatlar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tip = table.Column<string>(type: "varchar(150)", nullable: true),
                    DosyaYetkisi = table.Column<bool>(nullable: false),
                    TelNo = table.Column<string>(type: "varchar(20)", nullable: false),
                    FaxNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    TCKN = table.Column<string>(type: "varchar(11)", nullable: false),
                    AktifMi = table.Column<bool>(nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: true),
                    Guncelleyen = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: true),
                    SilenKisi = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilindiMi = table.Column<bool>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: true),
                    EkleyenKisi = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avukatlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvukatAtananUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    MusteriUrunId = table.Column<int>(nullable: false),
                    AvukatId = table.Column<int>(nullable: false),
                    AtamaTarihi = table.Column<DateTime>(nullable: false),
                    KabulTarihi = table.Column<DateTime>(nullable: false),
                    DelegasyonTarihi = table.Column<DateTime>(nullable: false),
                    Durum = table.Column<string>(type: "varchar(300)", nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: true),
                    Guncelleyen = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: true),
                    SilenKisi = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilindiMi = table.Column<bool>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: true),
                    EkleyenKisi = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvukatAtananUrunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvukatAtananUrunler_Avukatlar_AvukatId",
                        column: x => x.AvukatId,
                        principalTable: "Avukatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvukatAtananUrunler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvukatAtananUrunler_MusteriUrunler_MusteriUrunId",
                        column: x => x.MusteriUrunId,
                        principalTable: "MusteriUrunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IcraTakipler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: true),
                    AvukatId = table.Column<int>(nullable: true),
                    AvukatAtananUrunlerId = table.Column<int>(nullable: false),
                    TakipTipi = table.Column<string>(type: "varchar(50)", nullable: false),
                    IcraDairesi = table.Column<string>(type: "varchar(100)", nullable: false),
                    TakipTarihi = table.Column<DateTime>(nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", nullable: true),
                    DosyaNo = table.Column<string>(type: "varchar(150)", nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: true),
                    Guncelleyen = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: true),
                    SilenKisi = table.Column<string>(type: "varchar(20)", nullable: true),
                    SilindiMi = table.Column<bool>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: true),
                    EkleyenKisi = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcraTakipler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IcraTakipler_AvukatAtananUrunler_AvukatAtananUrunlerId",
                        column: x => x.AvukatAtananUrunlerId,
                        principalTable: "AvukatAtananUrunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IcraTakipler_Avukatlar_AvukatId",
                        column: x => x.AvukatId,
                        principalTable: "Avukatlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IcraTakipler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvukatAtananUrunler_AvukatId",
                table: "AvukatAtananUrunler",
                column: "AvukatId");

            migrationBuilder.CreateIndex(
                name: "IX_AvukatAtananUrunler_MusteriId",
                table: "AvukatAtananUrunler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_AvukatAtananUrunler_MusteriUrunId",
                table: "AvukatAtananUrunler",
                column: "MusteriUrunId");

            migrationBuilder.CreateIndex(
                name: "IX_IcraTakipler_AvukatAtananUrunlerId",
                table: "IcraTakipler",
                column: "AvukatAtananUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_IcraTakipler_AvukatId",
                table: "IcraTakipler",
                column: "AvukatId");

            migrationBuilder.CreateIndex(
                name: "IX_IcraTakipler_MusteriId",
                table: "IcraTakipler",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IcraTakipler");

            migrationBuilder.DropTable(
                name: "AvukatAtananUrunler");

            migrationBuilder.DropTable(
                name: "Avukatlar");
        }
    }
}
