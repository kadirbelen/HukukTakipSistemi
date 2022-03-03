using Microsoft.EntityFrameworkCore.Migrations;

namespace Hukuk.Takip.Sistemi.Entities.Migrations
{
    public partial class IliskilerDuzenlendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MusteriUrunler_MusteriId",
                table: "MusteriUrunler",
                column: "MusteriId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusteriUrunler_Musteriler_MusteriId",
                table: "MusteriUrunler",
                column: "MusteriId",
                principalTable: "Musteriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusteriUrunler_Musteriler_MusteriId",
                table: "MusteriUrunler");

            migrationBuilder.DropIndex(
                name: "IX_MusteriUrunler_MusteriId",
                table: "MusteriUrunler");
        }
    }
}
