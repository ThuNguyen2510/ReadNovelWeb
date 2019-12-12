using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicAPI.Migrations
{
    public partial class init : Migration
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
                    UserID = table.Column<int>(nullable: false),
                    ComicID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comment_Comic_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Like",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    ComicID = table.Column<int>(nullable: false),
                    check = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Like", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Like_Comic_ComicID",
                        column: x => x.ComicID,
                        principalTable: "Comic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Like_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    PostContent = table.Column<string>(nullable: true),
                    PostTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Post_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnswerTime = table.Column<DateTime>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    PostID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Answer_Post_PostID",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LikePost",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    PostID = table.Column<int>(nullable: false),
                    check = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikePost", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LikePost_Post_PostID",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comic",
                columns: new[] { "ID", "Author", "Chapter_long", "Description", "GenreID", "Image", "Likes", "Name", "Status", "Update_time", "Views" },
                values: new object[,]
                {
                    { 1, "Đỗ Cầm", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 3, "https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg", 23, "Công Cuộc Bị 999 Em Gái Chinh Phục", 0, new DateTime(2019, 12, 10, 22, 8, 9, 667, DateTimeKind.Local).AddTicks(5951), 100 },
                    { 12, "Diệp Sáp", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 6, "https://sstruyen.com/assets/img/story//ho-ly-muon-lam-nguoi-mau.jpg", 4, "Hồ Ly Muốn Làm Người Mẫu", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2805), 100 },
                    { 11, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 5, "https://sstruyen.com/assets/img/story//ieu-mac-su.jpg", 5, "Điều Mặc Sư", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2804), 100 },
                    { 10, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 8, "https://sstruyen.com/assets/img/story//su-huynh-rat-vo-luong.jpg", 12, "Sư Huynh, Rất Vô Lương", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2802), 100 },
                    { 9, "Bắc Chi", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 7, "https://sstruyen.com/assets/img/story//xin-hay-om-em.jpg", 20, "Xin Hãy Ôm Em", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2800), 100 },
                    { 8, "Mạc Vân Trà Sữa", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 3, "https://sstruyen.com/assets/img/story//ca-oi-chi-yeu-em.jpg", 45, "Cả Đời Chỉ Yêu Em", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2799), 100 },
                    { 7, "Tùng Lan", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 1, "https://sstruyen.com/assets/img/story//benh-chiem-huu.1573147505.jpg", 15, "Bệnh Chiếm Hữu", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2797), 100 },
                    { 6, "Thất Nguyệt Tửu Tiên", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 5, "https://sstruyen.com/assets/img/story//tat-ca-ban-gai-cua-toi-deu-la-le-quy.1572759769.jpg", 45, "Tất Cả Bạn Gái Của Tôi Đều Là Lệ Quỷ", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2796), 100 },
                    { 5, "Hoành Tảo Thiên Nhai", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 1, "https://sstruyen.com/assets/img/story//thien-ao-o-thu-quan.jpg", 30, "Thiên Đạo Đồ Thư Quán", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2794), 100 },
                    { 4, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 4, "https://sstruyen.com/assets/img/story//yeu-sau-nang-e-thieu-am-tham-cung-chieu-vo.jpg", 11, "Yêu Sâu Nặng", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2793), 100 },
                    { 3, "Trì Đường", 0, " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé", 2, "https://sstruyen.com/assets/img/story//truyen-nhan-tru-ma-ban-trai-toi-la-cuong-thi.jpg", 11, "Truyền Nhân Trừ Ma", 1, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2791), 100 },
                    { 2, "Phong Tử Tam Tam", 0, "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.", 8, "https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg", 44, "Câu Chuyện Hồ Đồ", 0, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(2777), 100 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreID", "Genre_name" },
                values: new object[,]
                {
                    { 15, "Truyện ngược" },
                    { 1, "Trinh Thám" },
                    { 13, "Huyền huyễn" },
                    { 2, "Ngôn Tình" },
                    { 3, "Viễn Tưởng" },
                    { 4, "Xuyên Không" },
                    { 5, "Dị Giới" },
                    { 14, "Dị năng" },
                    { 7, "Cổ đại" },
                    { 6, "Lịch sử" },
                    { 9, "Võng du" },
                    { 10, "Đô thị" },
                    { 11, "Quân sự" },
                    { 12, "Linh dị" },
                    { 8, "Sắc hiệp" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "Email", "Image", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 4, "admin@gmail.com", "https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg", "12345", 1, "Admin" },
                    { 1, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "ThuNguyen" },
                    { 2, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "NhutThuy" },
                    { 3, "user@gmail.com", "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg", "12345", 0, "TuongVi" },
                    { 5, "collaborator@gmail.com", "https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg", "12345", 2, "Collaborator" }
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
                table: "Comment",
                columns: new[] { "ID", "ComicID", "CommentTime", "Content", "UserID" },
                values: new object[,]
                {
                    { 7, 5, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(3106), "truyện quá đẳng cấp :) nếu so với mấy thứ yy tự kỷ cứ như là Iphone với Bphone", 3 },
                    { 6, 11, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(2416), "dịch rồi mà k ai convert hết @@ truyện hay mà", 3 },
                    { 3, 9, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(106), "Không ai dịch tiếp hả ?", 3 },
                    { 5, 7, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(1715), "đọc đến chương 73-74 thấy tội anh Cố Yến Trinh mặc dù cùng họ với anh Cố Gia Minh nhưng die oan vãi chỉ định hù dọa anh Nghị ai ngờ họa sát thân", 2 },
                    { 2, 10, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(9051), "Giữ tiến độ nha", 2 },
                    { 4, 11, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(979), "Bạo chương nha các bạn", 1 },
                    { 1, 11, new DateTime(2019, 12, 10, 22, 8, 9, 668, DateTimeKind.Local).AddTicks(3849), "Truyện này hay lắm dịch giả cố lên nha", 1 }
                });

            migrationBuilder.InsertData(
                table: "Like",
                columns: new[] { "ID", "ComicID", "UserID", "check" },
                values: new object[,]
                {
                    { 3, 2, 1, true },
                    { 1, 1, 1, true },
                    { 2, 1, 3, true },
                    { 4, 4, 3, true },
                    { 6, 6, 3, true },
                    { 5, 5, 1, true }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "ID", "PostContent", "PostTime", "Title", "UserID" },
                values: new object[,]
                {
                    { 1, "Mn tim giup minh cuon truyen", new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(5127), "Tìm truyện sắc hiệp", 1 },
                    { 3, "Có trường hợp nào hộp thiên giới rỗng ko các đh. Ta nhận đc 1 hộp mà mở ra nó lag. Tải lại thì hộp ko còn mà vật phẩm cũng chẳng có", new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(5707), "Thắc mắc hộp thiên giới", 3 },
                    { 2, "Tác phẩm các đh hay nhất từng đọc tên là gì. (Trong này có vài tác phẩm để đời ai cần ghé qua)", new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(5698), "Help me", 2 },
                    { 4, "Như trên nha nhiều vợ tí nó ms thú vị ko thì nhạt bỏ mẹ ra các đạo hữu ạ", new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(5709), "Xin truyện main bá đạo. Quyết đoán ( và main có nhìu vợ)", 4 }
                });

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "ID", "AnswerTime", "Content", "PostID", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 10, 22, 8, 9, 669, DateTimeKind.Local).AddTicks(9316), "Ta đề cử Tối cường thần thoại đế hoàng , Thần khống thiên hạ", 1, 1 },
                    { 2, new DateTime(2019, 12, 10, 22, 8, 9, 670, DateTimeKind.Local).AddTicks(2345), "Linh vũ thiên hạ , hộ hoa cao thủ tại đô thị , 1 truyện huyền huyễn 1 truyện đô thị", 1, 2 },
                    { 3, new DateTime(2019, 12, 10, 22, 8, 9, 670, DateTimeKind.Local).AddTicks(3258), "Sao ta không lên cấp được nhỉ?", 2, 3 },
                    { 4, new DateTime(2019, 12, 10, 22, 8, 9, 670, DateTimeKind.Local).AddTicks(3977), "chờ các cao nhân vào chỉ điểm a. chở Dâm Lão huynh đệ lên tiếng a ", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "LikePost",
                columns: new[] { "ID", "PostID", "UserID", "check" },
                values: new object[,]
                {
                    { 1, 1, 1, true },
                    { 2, 1, 3, true },
                    { 3, 2, 1, true },
                    { 6, 2, 3, true },
                    { 5, 3, 1, true },
                    { 4, 4, 3, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_PostID",
                table: "Answer",
                column: "PostID");

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
                name: "IX_Like_ComicID",
                table: "Like",
                column: "ComicID");

            migrationBuilder.CreateIndex(
                name: "IX_Like_UserID",
                table: "Like",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_LikePost_PostID",
                table: "LikePost",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_UserID",
                table: "Post",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "ComicGenre");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Like");

            migrationBuilder.DropTable(
                name: "LikePost");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Comic");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
