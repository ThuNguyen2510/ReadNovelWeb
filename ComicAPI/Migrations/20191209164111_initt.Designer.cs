﻿// <auto-generated />
using System;
using ComicAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComicAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191209164111_initt")]
    partial class initt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComicAPI.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre_name");

                    b.HasKey("GenreID");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            Genre_name = "Trinh Thám"
                        },
                        new
                        {
                            GenreID = 2,
                            Genre_name = "Ngôn Tình"
                        },
                        new
                        {
                            GenreID = 3,
                            Genre_name = "Viễn Tưởng"
                        },
                        new
                        {
                            GenreID = 4,
                            Genre_name = "Xuyên Không"
                        },
                        new
                        {
                            GenreID = 5,
                            Genre_name = "Dị Giới"
                        },
                        new
                        {
                            GenreID = 6,
                            Genre_name = "Lịch sử"
                        },
                        new
                        {
                            GenreID = 7,
                            Genre_name = "Cổ đại"
                        },
                        new
                        {
                            GenreID = 8,
                            Genre_name = "Sắc hiệp"
                        },
                        new
                        {
                            GenreID = 9,
                            Genre_name = "Võng du"
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Answer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AnswerTime");

                    b.Property<string>("Content");

                    b.Property<int>("PostID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AnswerTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(9918),
                            Content = "Ta đề cử Tối cường thần thoại đế hoàng , Thần khống thiên hạ",
                            PostID = 1,
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            AnswerTime = new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(3740),
                            Content = "Linh vũ thiên hạ , hộ hoa cao thủ tại đô thị , 1 truyện huyền huyễn 1 truyện đô thị",
                            PostID = 1,
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            AnswerTime = new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(4860),
                            Content = "Sao ta không lên cấp được nhỉ?",
                            PostID = 2,
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            AnswerTime = new DateTime(2019, 12, 9, 23, 41, 10, 550, DateTimeKind.Local).AddTicks(5737),
                            Content = "chờ các cao nhân vào chỉ điểm a. chở Dâm Lão huynh đệ lên tiếng a ",
                            PostID = 2,
                            UserID = 1
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Chapter", b =>
                {
                    b.Property<int>("ChapterID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComicID");

                    b.Property<string>("Content");

                    b.Property<int>("STT");

                    b.Property<string>("Title");

                    b.HasKey("ChapterID");

                    b.HasIndex("ComicID");

                    b.ToTable("Chapter");

                    b.HasData(
                        new
                        {
                            ChapterID = 1,
                            ComicID = 1,
                            Content = "",
                            STT = 1,
                            Title = "Đỗ Mạnh Cầm"
                        },
                        new
                        {
                            ChapterID = 2,
                            ComicID = 1,
                            Content = "",
                            STT = 2,
                            Title = "Khổ luyện"
                        },
                        new
                        {
                            ChapterID = 3,
                            ComicID = 2,
                            Content = "",
                            STT = 1,
                            Title = "Bộ mặt thật của 3 bà chị"
                        },
                        new
                        {
                            ChapterID = 4,
                            ComicID = 2,
                            Content = "",
                            STT = 2,
                            Title = "Xui Kiếp"
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Comic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<int>("Chapter_long");

                    b.Property<string>("Description");

                    b.Property<int>("GenreID");

                    b.Property<string>("Image");

                    b.Property<int>("Likes");

                    b.Property<string>("Name");

                    b.Property<int>("Status");

                    b.Property<DateTime>("Update_time");

                    b.Property<int>("Views");

                    b.HasKey("ID");

                    b.ToTable("Comic");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Author = "Đỗ Cầm",
                            Chapter_long = 0,
                            Description = " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                            GenreID = 3,
                            Image = "https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg",
                            Likes = 23,
                            Name = "Công Cuộc Bị 999 Em Gái Chinh Phục",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(1604),
                            Views = 100
                        },
                        new
                        {
                            ID = 2,
                            Author = "Phong Tử Tam Tam",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 8,
                            Image = "https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg",
                            Likes = 44,
                            Name = "Câu Chuyện Hồ Đồ",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9218),
                            Views = 100
                        },
                        new
                        {
                            ID = 3,
                            Author = "Trì Đường",
                            Chapter_long = 0,
                            Description = " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                            GenreID = 2,
                            Image = "https://sstruyen.com/assets/img/story//truyen-nhan-tru-ma-ban-trai-toi-la-cuong-thi.jpg",
                            Likes = 11,
                            Name = "Truyền Nhân Trừ Ma",
                            Status = 1,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9235),
                            Views = 100
                        },
                        new
                        {
                            ID = 4,
                            Author = "Phong Tử Tam Tam",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 4,
                            Image = "https://sstruyen.com/assets/img/story//yeu-sau-nang-e-thieu-am-tham-cung-chieu-vo.jpg",
                            Likes = 11,
                            Name = "Yêu Sâu Nặng",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9238),
                            Views = 100
                        },
                        new
                        {
                            ID = 5,
                            Author = "Hoành Tảo Thiên Nhai",
                            Chapter_long = 0,
                            Description = " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                            GenreID = 1,
                            Image = "https://sstruyen.com/assets/img/story//thien-ao-o-thu-quan.jpg",
                            Likes = 30,
                            Name = "Thiên Đạo Đồ Thư Quán",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9241),
                            Views = 100
                        },
                        new
                        {
                            ID = 6,
                            Author = "Thất Nguyệt Tửu Tiên",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 5,
                            Image = "https://sstruyen.com/assets/img/story//tat-ca-ban-gai-cua-toi-deu-la-le-quy.1572759769.jpg",
                            Likes = 45,
                            Name = "Tất Cả Bạn Gái Của Tôi Đều Là Lệ Quỷ",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9243),
                            Views = 100
                        },
                        new
                        {
                            ID = 7,
                            Author = "Tùng Lan",
                            Chapter_long = 0,
                            Description = " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                            GenreID = 1,
                            Image = "https://sstruyen.com/assets/img/story//benh-chiem-huu.1573147505.jpg",
                            Likes = 15,
                            Name = "Bệnh Chiếm Hữu",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9245),
                            Views = 100
                        },
                        new
                        {
                            ID = 8,
                            Author = "Mạc Vân Trà Sữa",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 3,
                            Image = "https://sstruyen.com/assets/img/story//ca-oi-chi-yeu-em.jpg",
                            Likes = 45,
                            Name = "Cả Đời Chỉ Yêu Em",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9247),
                            Views = 100
                        },
                        new
                        {
                            ID = 9,
                            Author = "Bắc Chi",
                            Chapter_long = 0,
                            Description = " Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                            GenreID = 7,
                            Image = "https://sstruyen.com/assets/img/story//xin-hay-om-em.jpg",
                            Likes = 20,
                            Name = "Xin Hãy Ôm Em",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9249),
                            Views = 100
                        },
                        new
                        {
                            ID = 10,
                            Author = "Phong Tử Tam Tam",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 8,
                            Image = "https://sstruyen.com/assets/img/story//su-huynh-rat-vo-luong.jpg",
                            Likes = 12,
                            Name = "Sư Huynh, Rất Vô Lương",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9251),
                            Views = 100
                        },
                        new
                        {
                            ID = 11,
                            Author = "Phong Tử Tam Tam",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 5,
                            Image = "https://sstruyen.com/assets/img/story//ieu-mac-su.jpg",
                            Likes = 5,
                            Name = "Điều Mặc Sư",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9253),
                            Views = 100
                        },
                        new
                        {
                            ID = 12,
                            Author = "Diệp Sáp",
                            Chapter_long = 0,
                            Description = "Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                            GenreID = 6,
                            Image = "https://sstruyen.com/assets/img/story//ho-ly-muon-lam-nguoi-mau.jpg",
                            Likes = 4,
                            Name = "Hồ Ly Muốn Làm Người Mẫu",
                            Status = 0,
                            Update_time = new DateTime(2019, 12, 9, 23, 41, 10, 547, DateTimeKind.Local).AddTicks(9255),
                            Views = 100
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.ComicGenre", b =>
                {
                    b.Property<int>("ComicID");

                    b.Property<int>("GenreID");

                    b.HasKey("ComicID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("ComicGenre");
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComicID");

                    b.Property<DateTime>("CommentTime");

                    b.Property<string>("Content");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ComicID");

                    b.HasIndex("UserID");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ComicID = 11,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(844),
                            Content = "Truyện này hay lắm dịch giả cố lên nha",
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            ComicID = 10,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(7566),
                            Content = "Giữ tiến độ nha",
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            ComicID = 9,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(8898),
                            Content = "Không ai dịch tiếp hả ?",
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            ComicID = 11,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 548, DateTimeKind.Local).AddTicks(9807),
                            Content = "Bạo chương nha các bạn",
                            UserID = 1
                        },
                        new
                        {
                            ID = 5,
                            ComicID = 7,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(664),
                            Content = "đọc đến chương 73-74 thấy tội anh Cố Yến Trinh mặc dù cùng họ với anh Cố Gia Minh nhưng die oan vãi chỉ định hù dọa anh Nghị ai ngờ họa sát thân",
                            UserID = 2
                        },
                        new
                        {
                            ID = 6,
                            ComicID = 11,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(1507),
                            Content = "dịch rồi mà k ai convert hết @@ truyện hay mà",
                            UserID = 3
                        },
                        new
                        {
                            ID = 7,
                            ComicID = 5,
                            CommentTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(2342),
                            Content = "truyện quá đẳng cấp :) nếu so với mấy thứ yy tự kỷ cứ như là Iphone với Bphone",
                            UserID = 3
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Like", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComicID");

                    b.Property<int>("UserID");

                    b.Property<bool>("check");

                    b.HasKey("ID");

                    b.HasIndex("ComicID");

                    b.HasIndex("UserID");

                    b.ToTable("Like");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ComicID = 1,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 2,
                            ComicID = 1,
                            UserID = 3,
                            check = true
                        },
                        new
                        {
                            ID = 3,
                            ComicID = 2,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 4,
                            ComicID = 4,
                            UserID = 3,
                            check = true
                        },
                        new
                        {
                            ID = 5,
                            ComicID = 5,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 6,
                            ComicID = 6,
                            UserID = 3,
                            check = true
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.LikePost", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PostID");

                    b.Property<int>("UserID");

                    b.Property<bool>("check");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("LikePost");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            PostID = 1,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 2,
                            PostID = 1,
                            UserID = 3,
                            check = true
                        },
                        new
                        {
                            ID = 3,
                            PostID = 2,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 4,
                            PostID = 4,
                            UserID = 3,
                            check = true
                        },
                        new
                        {
                            ID = 5,
                            PostID = 3,
                            UserID = 1,
                            check = true
                        },
                        new
                        {
                            ID = 6,
                            PostID = 2,
                            UserID = 3,
                            check = true
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostContent");

                    b.Property<DateTime>("PostTime");

                    b.Property<string>("Title");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            PostContent = "Mn tim giup minh cuon truyen",
                            PostTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(4807),
                            Title = "Tìm truyện sắc hiệp",
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            PostContent = "Tác phẩm các đh hay nhất từng đọc tên là gì. (Trong này có vài tác phẩm để đời ai cần ghé qua)",
                            PostTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5499),
                            Title = "Help me",
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            PostContent = "Có trường hợp nào hộp thiên giới rỗng ko các đh. Ta nhận đc 1 hộp mà mở ra nó lag. Tải lại thì hộp ko còn mà vật phẩm cũng chẳng có",
                            PostTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5510),
                            Title = "Thắc mắc hộp thiên giới",
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            PostContent = "Như trên nha nhiều vợ tí nó ms thú vị ko thì nhạt bỏ mẹ ra các đạo hữu ạ",
                            PostTime = new DateTime(2019, 12, 9, 23, 41, 10, 549, DateTimeKind.Local).AddTicks(5512),
                            Title = "Xin truyện main bá đạo. Quyết đoán ( và main có nhìu vợ)",
                            UserID = 4
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<string>("Password");

                    b.Property<int>("Role");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "user@gmail.com",
                            Image = "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg",
                            Password = "12345",
                            Role = 0,
                            Username = "ThuNguyen"
                        },
                        new
                        {
                            ID = 2,
                            Email = "user@gmail.com",
                            Image = "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg",
                            Password = "12345",
                            Role = 0,
                            Username = "NhutThuy"
                        },
                        new
                        {
                            ID = 3,
                            Email = "user@gmail.com",
                            Image = "https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg",
                            Password = "12345",
                            Role = 0,
                            Username = "TuongVi"
                        },
                        new
                        {
                            ID = 4,
                            Email = "admin@gmail.com",
                            Image = "https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg",
                            Password = "12345",
                            Role = 1,
                            Username = "Admin"
                        },
                        new
                        {
                            ID = 5,
                            Email = "collaborator@gmail.com",
                            Image = "https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg",
                            Password = "12345",
                            Role = 2,
                            Username = "Collaborator"
                        });
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Answer", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Post", "Post")
                        .WithMany("Answers")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Chapter", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Comic", "Comic")
                        .WithMany("Chapters")
                        .HasForeignKey("ComicID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.ComicGenre", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Comic", "Comic")
                        .WithMany()
                        .HasForeignKey("ComicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComicAPI.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Comment", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Comic", "Comic")
                        .WithMany("Comments")
                        .HasForeignKey("ComicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComicAPI.Models.Entities.User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Like", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Comic", "Comic")
                        .WithMany("Likesc")
                        .HasForeignKey("ComicID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ComicAPI.Models.Entities.User", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.LikePost", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.Post", "Post")
                        .WithMany("LikePosts")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ComicAPI.Models.Entities.Post", b =>
                {
                    b.HasOne("ComicAPI.Models.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
