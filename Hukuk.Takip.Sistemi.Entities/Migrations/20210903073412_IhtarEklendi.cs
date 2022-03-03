using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class IhtarEklendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ihtarlar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoterAd = table.Column<string>(nullable: true),
                    TakipHesapNo = table.Column<string>(nullable: true),
                    IhtarTarihi = table.Column<DateTime>(nullable: false),
                    IhtarTebligTarihi = table.Column<DateTime>(nullable: true),
                    IhtarTutar = table.Column<decimal>(nullable: true),
                    YevmiyeNo = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Ihtarlar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ihtarlar");
        }
    }
}
