using Microsoft.EntityFrameworkCore;
using ComicAPI.Models.Entities;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace ComicAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {     }
        public DbSet<User> Users {get;set;}
        public DbSet<Comic> Comics {get;set;}
        public DbSet<Genre> Genres {get;set;}
        public DbSet<Chapter> Chapters {get;set;}
        public DbSet<ComicGenre> ComicGenres{get;set;}
        public DbSet<Comment> Comments{get;set;}
       public DbSet<Post> Posts{get;set;}
       public DbSet<Answer> Answers{get;set;}
       public DbSet<Like> Likes{get;set;}
        public DbSet<LikePost> LikePosts{get;set;}

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Chapter>().ToTable("Chapter");
            modelBuilder.Entity<Comic>().ToTable("Comic");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<ComicGenre>().ToTable("ComicGenre");
            modelBuilder.Entity<ComicGenre>().HasKey(c=> new {c.ComicID,c.GenreID});     
            modelBuilder.Entity<Comment>().ToTable("Comment"); 
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Like>().ToTable("Like");
            modelBuilder.Entity<Answer>().ToTable("Answer");
            modelBuilder.Entity<LikePost>().ToTable("LikePost");
            var users= new User[]
            {
                 new User { ID=1, Username = "ThuNguyen",   Email = "user@gmail.com",
                Password="12345",Role=0,Image="https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg"
                    },
                 new User { ID=2, Username = "NhutThuy",   Email = "user@gmail.com",
                Password="12345",Role=0,Image="https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg"
                    },
                     new User {ID=3,Username = "TuongVi",   Email = "user@gmail.com",
                Password="12345",Role=0,Image="https://middle.pngfans.com/20190505/lx/avatar-user-png-avatar-computer-icons-clipart-c26add6546fc41bb.jpg"
                    },
                     new User {ID=4, Username = "Admin",   Email = "admin@gmail.com",
                Password="12345",Role=1,Image="https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg"
                    }                    ,
                     new User {ID=5, Username = "Collaborator",   Email = "collaborator@gmail.com",
                Password="12345",Role=2,Image="https://cactusthemes.com/blog/wp-content/uploads/2018/01/tt_avatar_small.jpg"
                    }
            }     ;
            modelBuilder.Entity<User>().HasData(users);
             var genres= new Genre[]
             {
                new Genre{ GenreID=1,Genre_name="Trinh Thám" },
                new Genre{ GenreID=2,Genre_name="Ngôn Tình" },
                new Genre{ GenreID=3,Genre_name="Viễn Tưởng" },
                new Genre{ GenreID=4,Genre_name="Xuyên Không" },
                new Genre{ GenreID=5,Genre_name="Dị Giới" },
                new Genre{ GenreID=6,Genre_name="Lịch sử" },
                new Genre{ GenreID=7,Genre_name="Cổ đại" },
                new Genre{ GenreID=8,Genre_name="Sắc hiệp" },
                new Genre{ GenreID=9,Genre_name="Võng du" }
             };
             modelBuilder.Entity<Genre>().HasData(genres);
               var chapters =new Chapter[]
             {
                 new Chapter{
                     ChapterID=1,ComicID=1,Title="Đỗ Mạnh Cầm",STT=1,
                     Content= "",                     
                 },
                  new Chapter{
                     ChapterID=2,ComicID=1,Title="Khổ luyện",STT=2,
                     Content= ""},
                  new Chapter{
                     ChapterID=3,ComicID=2,Title="Bộ mặt thật của 3 bà chị",STT=1,
                     Content="" },
                  new Chapter{
                     ChapterID=4,ComicID=2,Title="Xui Kiếp",STT=2,
                     Content=""  }
             };
             
             var comics=new Comic[]
             {
                  new Comic{ID=1, Name="Công Cuộc Bị 999 Em Gái Chinh Phục",Status=0,Author="Đỗ Cầm",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=23,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg",
                    GenreID=3
                 },
                  new Comic{ID=2, Name="Câu Chuyện Hồ Đồ",Status=0,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=44,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg",
                    GenreID=8
                 },
                 new Comic{ID=3, Name="Truyền Nhân Trừ Ma",Status=1,Author="Trì Đường",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=11,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//truyen-nhan-tru-ma-ban-trai-toi-la-cuong-thi.jpg",
                    GenreID=2
                 },
                  new Comic{ID=4, Name="Yêu Sâu Nặng",Status=1,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=11,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//yeu-sau-nang-e-thieu-am-tham-cung-chieu-vo.jpg",
                    GenreID=4
                 },
                 new Comic{ID=5, Name="Thiên Đạo Đồ Thư Quán",Status=0,Author="Hoành Tảo Thiên Nhai",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=30,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//thien-ao-o-thu-quan.jpg",
                    GenreID=1
                 },
                  new Comic{ID=6, Name="Tất Cả Bạn Gái Của Tôi Đều Là Lệ Quỷ",Status=0,Author="Thất Nguyệt Tửu Tiên",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=45,Views=100,Update_time= DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//tat-ca-ban-gai-cua-toi-deu-la-le-quy.1572759769.jpg",
                    GenreID=5
                 },
                 new Comic{ID=7, Name="Bệnh Chiếm Hữu",Status=1,Author="Tùng Lan",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=15,Views=100,Update_time= DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//benh-chiem-huu.1573147505.jpg",
                    GenreID=1
                 },
                  new Comic{ID=8, Name="Cả Đời Chỉ Yêu Em",Status=0,Author="Mạc Vân Trà Sữa",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=45,Views=100,Update_time= DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//ca-oi-chi-yeu-em.jpg",
                    GenreID=3
                 },
                 new Comic{ID=9, Name="Xin Hãy Ôm Em",Status=1,Author="Bắc Chi",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=20,Views=100,Update_time= DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//xin-hay-om-em.jpg",
                    GenreID=7
                 },
                  new Comic{ID=10, Name="Sư Huynh, Rất Vô Lương",Status=0,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=12,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//su-huynh-rat-vo-luong.jpg",
                    GenreID=8
                 }
                 ,
                  new Comic{ID=11, Name="Điều Mặc Sư",Status=1,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=5,Views=100,Update_time= DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//ieu-mac-su.jpg",
                    GenreID=5
                 }
                 ,
                  new Comic{ID=12, Name="Hồ Ly Muốn Làm Người Mẫu",Status=0,Author="Diệp Sáp",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=4,Views=100,Update_time=DateTime.Now,
                    Image="https://sstruyen.com/assets/img/story//ho-ly-muon-lam-nguoi-mau.jpg",
                    GenreID=6
                 }
             };
            modelBuilder.Entity<Comic>().HasData(comics);              
            modelBuilder.Entity<Chapter>().HasData(chapters);
            
            var comments= new Comment[]
            {
                new Comment{
                    ID=1,CommentTime=DateTime.Now,
                    Content="Truyện này hay lắm dịch giả cố lên nha",
                    ComicID=comics.Single(s => s.Name == "Điều Mặc Sư").ID,
                    UserID=users.Single(e=>e.Username=="ThuNguyen").ID
                },
                 new Comment{
                    ID=2,CommentTime=DateTime.Now,
                    Content="Giữ tiến độ nha",
                    ComicID=comics.Single(s => s.Name == "Sư Huynh, Rất Vô Lương").ID,
                    UserID=users.Single(e=>e.Username=="NhutThuy").ID
                },
                 new Comment{
                    ID=3,CommentTime=DateTime.Now,
                    Content="Không ai dịch tiếp hả ?",
                    ComicID=comics.Single(s => s.Name == "Xin Hãy Ôm Em").ID,
                    UserID=users.Single(e=>e.Username=="TuongVi").ID
                },
                 new Comment{
                    ID=4,CommentTime=DateTime.Now,
                    Content="Bạo chương nha các bạn",
                    ComicID=comics.Single(s => s.Name == "Điều Mặc Sư").ID,
                    UserID=users.Single(e=>e.Username=="ThuNguyen").ID
                },
                 new Comment{
                    ID=5,CommentTime=DateTime.Now,
                    Content="đọc đến chương 73-74 thấy tội anh Cố Yến Trinh mặc dù cùng họ với anh Cố Gia Minh nhưng die oan vãi chỉ định hù dọa anh Nghị ai ngờ họa sát thân",
                    ComicID=comics.Single(s => s.Name == "Bệnh Chiếm Hữu").ID,
                    UserID=users.Single(e=>e.Username=="NhutThuy").ID
                }
                ,
                 new Comment{
                    ID=6,CommentTime=DateTime.Now,
                    Content="dịch rồi mà k ai convert hết @@ truyện hay mà",
                    ComicID=comics.Single(s => s.Name == "Điều Mặc Sư").ID,
                    UserID=users.Single(e=>e.Username=="TuongVi").ID
                },
                 new Comment{
                    ID=7,CommentTime=DateTime.Now,
                    Content="truyện quá đẳng cấp :) nếu so với mấy thứ yy tự kỷ cứ như là Iphone với Bphone",
                    ComicID=comics.Single(s => s.Name == "Thiên Đạo Đồ Thư Quán").ID,
                    UserID=users.Single(e=>e.Username=="TuongVi").ID
                }
            };
            modelBuilder.Entity<Comment>().HasData(comments);
             
             var posts= new Post[]
             {
                 new Post{
                     ID=1,UserID=1,PostContent="Mn tim giup minh cuon truyen",
                     PostTime=DateTime.Now,Title="Tìm truyện sắc hiệp"

                 },
                  new Post{
                     ID=2,UserID=2,PostContent="Tác phẩm các đh hay nhất từng đọc tên là gì. (Trong này có vài tác phẩm để đời ai cần ghé qua)",
                     PostTime=DateTime.Now,Title="Help me"

                 },
                  new Post{
                     ID=3,UserID=3,PostContent="Có trường hợp nào hộp thiên giới rỗng ko các đh. Ta nhận đc 1 hộp mà mở ra nó lag. Tải lại thì hộp ko còn mà vật phẩm cũng chẳng có",
                     PostTime=DateTime.Now,Title="Thắc mắc hộp thiên giới"

                 },
                  new Post{
                     ID=4,UserID=4,PostContent="Như trên nha nhiều vợ tí nó ms thú vị ko thì nhạt bỏ mẹ ra các đạo hữu ạ",
                     PostTime=DateTime.Now,Title="Xin truyện main bá đạo. Quyết đoán ( và main có nhìu vợ)"

                 }
             };
            modelBuilder.Entity<Post>().HasData(posts);
            var likes= new Like[]
            {
                new Like{
                    ID=1,UserID=1,check=true,ComicID=1
                },
                 new Like{
                    ID=2,UserID=3,check=true,ComicID=1
                },
                new Like{
                    ID=3,UserID=1,check=true,ComicID=2
                },
                 new Like{
                    ID=4,UserID=3,check=true,ComicID=4
                },
                new Like{
                    ID=5,UserID=1,check=true,ComicID=5
                },
                 new Like{
                    ID=6,UserID=3,check=true,ComicID=6
                }
            };
            modelBuilder.Entity<Like>().HasData(likes);
            var LikePosts= new LikePost[]
            {
                new LikePost{
                    ID=1,UserID=1,check=true,PostID=1
                },
                 new LikePost{
                    ID=2,UserID=3,check=true,PostID=1
                },
                new LikePost{
                    ID=3,UserID=1,check=true,PostID=2
                },
                 new LikePost{
                    ID=4,UserID=3,check=true,PostID=4
                },
                new LikePost{
                    ID=5,UserID=1,check=true,PostID=3
                },
                 new LikePost{
                    ID=6,UserID=3,check=true,PostID=2
                }
            };
            modelBuilder.Entity<LikePost>().HasData(LikePosts);
            var answers= new Answer[]
            {
                new Answer{
                    ID=1,AnswerTime=DateTime.Now,UserID=users.Single(x=>x.Username=="ThuNguyen").ID,
                    PostID=posts.Single(x=>x.Title=="Tìm truyện sắc hiệp").ID,
                    Content="Ta đề cử Tối cường thần thoại đế hoàng , Thần khống thiên hạ"
                },
                new Answer{
                    ID=2,AnswerTime=DateTime.Now,UserID=users.Single(x=>x.Username=="NhutThuy").ID,
                    PostID=posts.Single(x=>x.Title=="Tìm truyện sắc hiệp").ID,
                    Content="Linh vũ thiên hạ , hộ hoa cao thủ tại đô thị , 1 truyện huyền huyễn 1 truyện đô thị"
                },
                
                new Answer{
                    ID=3,AnswerTime=DateTime.Now,UserID=users.Single(x=>x.Username=="TuongVi").ID,
                    PostID=posts.Single(x=>x.Title=="Help me").ID,
                    Content="Sao ta không lên cấp được nhỉ?"
                },
                new Answer{
                    ID=4,AnswerTime=DateTime.Now,UserID=users.Single(x=>x.Username=="ThuNguyen").ID,
                    PostID=posts.Single(x=>x.Title=="Help me").ID,
                    Content="chờ các cao nhân vào chỉ điểm a. chở Dâm Lão huynh đệ lên tiếng a "
                }
            };
            modelBuilder.Entity<Answer>().HasData(answers);      
       }
     
     
    }
}