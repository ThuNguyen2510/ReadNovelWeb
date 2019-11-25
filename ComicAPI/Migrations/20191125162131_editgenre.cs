using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class editgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComicGenre",
                keyColumns: new[] { "ComicID", "GenreID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ComicGenre",
                keyColumns: new[] { "ComicID", "GenreID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ComicGenre",
                keyColumns: new[] { "ComicID", "GenreID" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ComicGenre",
                keyColumns: new[] { "ComicID", "GenreID" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Comic",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 1,
                column: "GenreID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Comic",
                keyColumn: "ID",
                keyValue: 2,
                column: "GenreID",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Comic");

            migrationBuilder.InsertData(
                table: "ComicGenre",
                columns: new[] { "ComicID", "GenreID" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 1 },
                    { 2, 5 },
                    { 2, 3 }
                });
        }
    }
}
