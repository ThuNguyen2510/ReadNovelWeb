using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class DB_first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Chapter_long = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Views = table.Column<int>(nullable: false),
                    Update_time = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Genre_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    ChapterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComicId = table.Column<int>(nullable: false),
                    STT = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.ChapterID);
                    table.ForeignKey(
                        name: "FK_Chapter_Comic_ComicId",
                        column: x => x.ComicId,
                        principalTable: "Comic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicGenre",
                columns: table => new
                {
                    ComicID = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicGenre", x => new { x.ComicID, x.GenreID });
                    table.ForeignKey(
                        name: "FK_ComicGenre_Comic_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicGenre_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comic",
                columns: new[] { "ID", "Author", "Chapter_long", "Description", "Image", "Likes", "Name", "Status", "Update_time", "Views" },
                values: new object[,]
                {
                    { 1, "Đỗ Cầm", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", "https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg", 100, "Công Cuộc Bị 999 Em Gái Chinh Phục", 0, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", "https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg", 100, "Câu Chuyện Hồ Đồ", 0, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "Genre_name" },
                values: new object[,]
                {
                    { 1, "Trinh Thám" },
                    { 2, "Ngôn Tình" },
                    { 3, "Viễn Tưởng" },
                    { 4, "Xuyên Không" },
                    { 5, "Dị Giới" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "user@gmail.com", "12345", 0, "ThuNguyen" },
                    { 2, "user@gmail.com", "12345", 0, "NhutThuy" },
                    { 3, "user@gmail.com", "12345", 0, "TuongVi" },
                    { 4, "admin@gmail.com", "12345", 1, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "ChapterID", "ComicId", "Content", "STT", "Title" },
                values: new object[,]
                {
                    { 1, 1, "", 1, "Đỗ Mạnh Cầm" },
                    { 2, 1, "", 2, "Khổ luyện" },
                    { 3, 2, "", 1, "Bộ mặt thật của 3 bà chị" },
                    { 4, 2, "", 2, "Xui Kiếp" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_ComicId",
                table: "Chapter",
                column: "ComicId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicGenre_GenreID",
                table: "ComicGenre",
                column: "GenreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "ComicGenre");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "Genre");
        }
    }
}
