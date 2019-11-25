using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class update_comic_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Comic_ComicId",
                table: "Chapter");

            migrationBuilder.RenameColumn(
                name: "ComicId",
                table: "Chapter",
                newName: "ComicID");

            migrationBuilder.RenameIndex(
                name: "IX_Chapter_ComicId",
                table: "Chapter",
                newName: "IX_Chapter_ComicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Comic_ComicID",
                table: "Chapter",
                column: "ComicID",
                principalTable: "Comic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapter_Comic_ComicID",
                table: "Chapter");

            migrationBuilder.RenameColumn(
                name: "ComicID",
                table: "Chapter",
                newName: "ComicId");

            migrationBuilder.RenameIndex(
                name: "IX_Chapter_ComicID",
                table: "Chapter",
                newName: "IX_Chapter_ComicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapter_Comic_ComicId",
                table: "Chapter",
                column: "ComicId",
                principalTable: "Comic",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
