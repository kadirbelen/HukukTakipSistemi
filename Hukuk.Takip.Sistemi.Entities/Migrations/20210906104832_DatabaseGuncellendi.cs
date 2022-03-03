using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class DatabaseGuncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "MusteriUrunler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "MusteriUrunler");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "MusteriTelefonlar");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "MusteriTelefonlar");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Musteriler");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "MusteriAdresler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "MusteriAdresler");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "IhtarUrunler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "IhtarUrunler");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "Ihtarlar");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Ihtarlar");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "IcraTakipler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "IcraTakipler");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "Avukatlar");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Avukatlar");

            migrationBuilder.DropColumn(
                name: "SilenKisi",
                table: "AvukatAtananUrunler");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "AvukatAtananUrunler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "MusteriUrunler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriUrunler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "MusteriTelefonlar",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriTelefonlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "Musteriler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Musteriler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "MusteriAdresler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "MusteriAdresler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "IhtarUrunler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "IhtarUrunler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "Ihtarlar",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Ihtarlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "IcraTakipler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "IcraTakipler",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "Avukatlar",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Avukatlar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SilenKisi",
                table: "AvukatAtananUrunler",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "AvukatAtananUrunler",
                nullable: true);
        }
    }
}
