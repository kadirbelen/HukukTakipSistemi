using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class IliskilerEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IhtarTebligTarihi",
                table: "Ihtarlar",
                newName: "IhtarTebliğTarihi");

            migrationBuilder.AlterColumn<string>(
                name: "UrunTipKod",
                table: "MusteriUrunler",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunDurumu",
                table: "MusteriUrunler",
                type: "varchar(140)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunAd",
                table: "MusteriUrunler",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipTutar",
                table: "MusteriUrunler",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "TakipSubeKod",
                table: "MusteriUrunler",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "TakipSubeAd",
                table: "MusteriUrunler",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipHesapNo",
                table: "MusteriUrunler",
                type: "varchar(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParaBirimi",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OnErteleme",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MasrafSubeAd",
                table: "MusteriUrunler",
                type: "varchar(140)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MasrafHesap",
                table: "MusteriUrunler",
                type: "varchar(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaizSubeKod",
                table: "MusteriUrunler",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FaizSubeAd",
                table: "MusteriUrunler",
                type: "varchar(125)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FaizHesap",
                table: "MusteriUrunler",
                type: "varchar(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonTİpi",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonNo",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VKN",
                table: "Musteriler",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipSubeAdi",
                table: "Musteriler",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Musteriler",
                type: "varchar(11)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Musteriler",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "Musteriler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasaportNo",
                table: "Musteriler",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedeniHali",
                table: "Musteriler",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "Musteriler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "Musteriler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DogumYeri",
                table: "Musteriler",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cinsiyet",
                table: "Musteriler",
                type: "varchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BabaAdi",
                table: "Musteriler",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnaAdi",
                table: "Musteriler",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Musteriler",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriAdresler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sehir",
                table: "MusteriAdresler",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "MusteriAdresler",
                type: "varchar(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mahalle",
                table: "MusteriAdresler",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ilce",
                table: "MusteriAdresler",
                type: "varchar(40)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriAdresler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriAdresler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdresTipi",
                table: "MusteriAdresler",
                type: "varchar(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "MusteriAdresler",
                type: "varchar(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "IhtarUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "IhtarUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "IhtarUrunler",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IhtarId",
                table: "IhtarUrunler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MusteriUrunId",
                table: "IhtarUrunler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "TakipHesapNo",
                table: "Ihtarlar",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "Ihtarlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoterAd",
                table: "Ihtarlar",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "Ihtarlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "Ihtarlar",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusteriId",
                table: "Ihtarlar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IhtarUrunler_IhtarId",
                table: "IhtarUrunler",
                column: "IhtarId");

            migrationBuilder.CreateIndex(
                name: "IX_IhtarUrunler_MusteriUrunId",
                table: "IhtarUrunler",
                column: "MusteriUrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Ihtarlar_MusteriId",
                table: "Ihtarlar",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ihtarlar_Musteriler_MusteriId",
                table: "Ihtarlar",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IhtarUrunler_Ihtarlar_IhtarId",
                table: "IhtarUrunler",
                column: "IhtarId",
                principalTable: "Ihtarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IhtarUrunler_MusteriUrunler_MusteriUrunId",
                table: "IhtarUrunler",
                column: "MusteriUrunId",
                principalTable: "MusteriUrunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ihtarlar_Musteriler_MusteriId",
                table: "Ihtarlar");

            migrationBuilder.DropForeignKey(
                name: "FK_IhtarUrunler_Ihtarlar_IhtarId",
                table: "IhtarUrunler");

            migrationBuilder.DropForeignKey(
                name: "FK_IhtarUrunler_MusteriUrunler_MusteriUrunId",
                table: "IhtarUrunler");

            migrationBuilder.DropIndex(
                name: "IX_IhtarUrunler_IhtarId",
                table: "IhtarUrunler");

            migrationBuilder.DropIndex(
                name: "IX_IhtarUrunler_MusteriUrunId",
                table: "IhtarUrunler");

            migrationBuilder.DropIndex(
                name: "IX_Ihtarlar_MusteriId",
                table: "Ihtarlar");

            migrationBuilder.DropColumn(
                name: "IhtarId",
                table: "IhtarUrunler");

            migrationBuilder.DropColumn(
                name: "MusteriUrunId",
                table: "IhtarUrunler");

            migrationBuilder.DropColumn(
                name: "MusteriId",
                table: "Ihtarlar");

            migrationBuilder.RenameColumn(
                name: "IhtarTebliğTarihi",
                table: "Ihtarlar",
                newName: "IhtarTebligTarihi");

            migrationBuilder.AlterColumn<string>(
                name: "UrunTipKod",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "UrunDurumu",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(140)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrunAd",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TakipTutar",
                table: "MusteriUrunler",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<int>(
                name: "TakipSubeKod",
                table: "MusteriUrunler",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "TakipSubeAd",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "TakipHesapNo",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)");

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParaBirimi",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "OnErteleme",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MasrafSubeAd",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(140)");

            migrationBuilder.AlterColumn<string>(
                name: "MasrafHesap",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)");

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FaizSubeKod",
                table: "MusteriUrunler",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "FaizSubeAd",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(125)");

            migrationBuilder.AlterColumn<string>(
                name: "FaizHesap",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(8)");

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TelefonTİpi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "TelefonNo",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VKN",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipSubeAdi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soyad",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasaportNo",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MedeniHali",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DogumYeri",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cinsiyet",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BabaAdi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnaAdi",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sehir",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)");

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "Mahalle",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Ilce",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(40)");

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdresTipi",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)");

            migrationBuilder.AlterColumn<string>(
                name: "Adres",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)");

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "IhtarUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "IhtarUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "IhtarUrunler",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakipHesapNo",
                table: "Ihtarlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SilenKisi",
                table: "Ihtarlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoterAd",
                table: "Ihtarlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Guncelleyen",
                table: "Ihtarlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EkleyenKisi",
                table: "Ihtarlar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);
        }
    }
}
