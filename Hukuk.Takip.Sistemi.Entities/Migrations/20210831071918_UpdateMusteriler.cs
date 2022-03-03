using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class UpdateMusteriler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefonNo",
                table: "MusteriTelefonlar",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "VKN",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "PasaportNo",
                table: "Musteriler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "HayattaMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "SilindiMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "MusteriAdresler",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AnaAdresMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(byte));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TelefonNo",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "SilindiMi",
                table: "MusteriTelefonlar",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "VKN",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TCKN",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "SilindiMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PasaportNo",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "HayattaMi",
                table: "Musteriler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<byte>(
                name: "SilindiMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PostaKodu",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "AnaAdresMi",
                table: "MusteriAdresler",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
