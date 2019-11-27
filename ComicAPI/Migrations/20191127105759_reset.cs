using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class reset : Migration
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
                    Image = table.Column<string>(nullable: true),
                    GenreID = table.Column<int>(nullable: false)
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
                    Image = table.Column<string>(nullable: true),
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
                    ComicID = table.Column<int>(nullable: false),
                    STT = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.ChapterID);
                    table.ForeignKey(
                        name: "FK_Chapter_Comic_ComicID",
                        column: x => x.ComicID,
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

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: true),
                    CommentTime = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<int>(nullable: true),
                    ComicID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comment_Comic_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserLikeID = table.Column<int>(nullable: false),
                    ComicID = table.Column<int>(nullable: false),
                    check = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Like_User_UserLikeID",
                        column: x => x.UserLikeID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserPostID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    PostContent = table.Column<string>(nullable: true),
                    PostTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_User_UserPostID",
                        column: x => x.UserPostID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comic",
                columns: new[] { "ID", "Author", "Chapter_long", "Description", "GenreID", "Image", "Likes", "Name", "Status", "Update_time", "Views" },
                values: new object[,]
                {
                    { 1, "Đỗ Cầm", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 1, "https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg", 100, "Công Cuộc Bị 999 Em Gái Chinh Phục", 0, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 4, "https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg", 100, "Câu Chuyện Hồ Đồ", 0, new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "ID", "ComicID", "CommentTime", "Content", "UserID" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OK", null },
                    { 2, null, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OK", null },
                    { 3, null, new DateTime(2019, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "OK", null }
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
                columns: new[] { "ID", "Email", "Image", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "ThuNguyen" },
                    { 2, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "NhutThuy" },
                    { 3, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "TuongVi" },
                    { 4, "admin@gmail.com", "https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg", "12345", 1, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Chapter",
                columns: new[] { "ChapterID", "ComicID", "Content", "STT", "Title" },
                values: new object[,]
                {
                    { 1, 1, "", 1, "Đỗ Mạnh Cầm" },
                    { 2, 1, "", 2, "Khổ luyện" },
                    { 3, 2, "", 1, "Bộ mặt thật của 3 bà chị" },
                    { 4, 2, "", 2, "Xui Kiếp" }
                });

            migrationBuilder.InsertData(
                table: "Like",
                columns: new[] { "ID", "ComicID", "UserLikeID", "check" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 1, 3, true }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "PostID", "PostContent", "PostTime", "Title", "UserPostID" },
                values: new object[,]
                {
                    { 1, "Mn tim giup minh cuon truyen", new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Help me", 1 },
                    { 2, "Mn tim giup minh cuon truyen", new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Help me", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_ComicID",
                table: "Chapter",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_ComicGenre_GenreID",
                table: "ComicGenre",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ComicID",
                table: "Comment",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UserLikeID",
                table: "Like",
                column: "UserLikeID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserPostID",
                table: "Post",
                column: "UserPostID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "ComicGenre");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
