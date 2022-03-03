using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class HukukTakipSistemi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriNo = table.Column<long>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    TCKN = table.Column<string>(nullable: false),
                    VKN = table.Column<string>(nullable: false),
                    PasaportNo = table.Column<string>(nullable: false),
                    BabaAdi = table.Column<string>(nullable: true),
                    AnaAdi = table.Column<string>(nullable: true),
                    DogumYeri = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Cinsiyet = table.Column<string>(nullable: false),
                    MedeniHali = table.Column<string>(nullable: false),
                    MusteriTipi = table.Column<int>(nullable: false),
                    TakipSubeKodu = table.Column<int>(nullable: false),
                    TakipSubeAdi = table.Column<string>(nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: false),
                    Guncelleyen = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: false),
                    SilenKisi = table.Column<string>(nullable: true),
                    SilindiMi = table.Column<byte>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: false),
                    EkleyenKisi = table.Column<string>(nullable: true),
                    HayattaMi = table.Column<byte>(nullable: false),
                    VefatTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriAdresler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    AdresTipi = table.Column<string>(nullable: true),
                    AnaAdresMi = table.Column<byte>(nullable: false),
                    Adres = table.Column<string>(nullable: true),
                    Mahalle = table.Column<string>(nullable: true),
                    Ilce = table.Column<string>(nullable: true),
                    Sehir = table.Column<string>(nullable: true),
                    PostaKodu = table.Column<string>(nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: false),
                    Guncelleyen = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: false),
                    SilenKisi = table.Column<string>(nullable: true),
                    SilindiMi = table.Column<byte>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: false),
                    EkleyenKisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriAdresler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriAdresler_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MusteriTelefonlar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriId = table.Column<int>(nullable: false),
                    TelefonTİpi = table.Column<string>(nullable: true),
                    TelefonNo = table.Column<string>(nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: false),
                    Guncelleyen = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: false),
                    SilenKisi = table.Column<string>(nullable: true),
                    SilindiMi = table.Column<byte>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: false),
                    EkleyenKisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTelefonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriTelefonlar_Musteriler_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusteriAdresler_MusteriId",
                table: "MusteriAdresler",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriTelefonlar_MusteriId",
                table: "MusteriTelefonlar",
                column: "MusteriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusteriAdresler");

            migrationBuilder.DropTable(
                name: "MusteriTelefonlar");

            migrationBuilder.DropTable(
                name: "Musteriler");
        }
    }
}
