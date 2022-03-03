using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class VerTabaniUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "SilindiMi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "VefatTarihi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "TakipSubeKodu",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "SilindiMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "MedeniHali",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<bool>(
                name: "HayattaMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "Cinsiyet",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "SilindiMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "AnaAdresMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "IhtarUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IhtarTutar = table.Column<decimal>(nullable: true),
                    AnaParaTutar = table.Column<decimal>(nullable: true),
                    FaizTutar = table.Column<decimal>(nullable: true),
                    KomisyonTutar = table.Column<decimal>(nullable: true),
                    ToplamBorc = table.Column<decimal>(nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: true),
                    Guncelleyen = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: true),
                    SilenKisi = table.Column<string>(nullable: true),
                    SilindiMi = table.Column<bool>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: true),
                    EkleyenKisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IhtarUrunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusteriUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrunAd = table.Column<string>(nullable: true),
                    UrunTipKod = table.Column<string>(nullable: true),
                    TakipSubeKod = table.Column<int>(nullable: false),
                    TakipSubeAd = table.Column<string>(nullable: true),
                    TakipHesapNo = table.Column<string>(nullable: true),
                    TakipTutar = table.Column<decimal>(nullable: false),
                    ParaBirimi = table.Column<string>(nullable: true),
                    TakipTarihi = table.Column<DateTime>(nullable: false),
                    MasrafSubeKodu = table.Column<int>(nullable: false),
                    MasrafSubeAd = table.Column<string>(nullable: true),
                    MasrafHesap = table.Column<string>(nullable: true),
                    MasrafTutar = table.Column<decimal>(nullable: false),
                    FaizSubeKod = table.Column<int>(nullable: false),
                    FaizSubeAd = table.Column<string>(nullable: true),
                    FaizHesap = table.Column<string>(nullable: true),
                    FaizTutar = table.Column<decimal>(nullable: false),
                    ErtelemeVarMi = table.Column<bool>(nullable: false),
                    OnErteleme = table.Column<string>(nullable: true),
                    UrunDurumu = table.Column<string>(nullable: true),
                    ToplamRiskTutar = table.Column<decimal>(nullable: true),
                    GuncellenmeTarihi = table.Column<DateTime>(nullable: true),
                    Guncelleyen = table.Column<string>(nullable: true),
                    SilinmeTarihi = table.Column<DateTime>(nullable: true),
                    SilenKisi = table.Column<string>(nullable: true),
                    SilindiMi = table.Column<bool>(nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(nullable: true),
                    EkleyenKisi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriUrunler", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IhtarUrunler");

            migrationBuilder.DropTable(
                name: "MusteriUrunler");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VefatTarihi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TakipSubeKodu",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "MedeniHali",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HayattaMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DogumTarihi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cinsiyet",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EklenmeTarihi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnaAdresMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
