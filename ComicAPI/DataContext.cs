using Microsoft.EntityFrameworkCore;
using ComicAPI.Models.Entities;
using System.Linq;
using System.Data.Entity.ModelConfiguration.Conventions;

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
       // public DbSet<Post> Posts{get;set;}
    //    public DbSet<Answer> Answers{get;set;}
      //  public DbSet<Like> Likes{get;set;}
     //   public DbSet<RepComment> RepComments{get;set;}

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
          //  modelBuilder.Entity<RepComment>().ToTable("Repcomment");
            modelBuilder.Entity<Like>().ToTable("Like");
           // modelBuilder.Entity<Answer>().ToTable("Answer");
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
                    }
            }     ;
            modelBuilder.Entity<User>().HasData(users);
             var genres= new Genre[]
             {
                new Genre{ GenreID=1,Genre_name="Trinh Thám" },
                new Genre{ GenreID=2,Genre_name="Ngôn Tình" },
                new Genre{ GenreID=3,Genre_name="Viễn Tưởng" },
                new Genre{ GenreID=4,Genre_name="Xuyên Không" },
                new Genre{ GenreID=5,Genre_name="Dị Giới" }
             };
             modelBuilder.Entity<Genre>().HasData(genres);
               var chapters =new Chapter[]
             {
                 new Chapter{
                     ChapterID=1,ComicID=1,Title="Đỗ Mạnh Cầm",STT=1,
                     Content=   "",                     
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
                    Chapter_long=0,Likes=100,Views=100,Update_time=new System.DateTime(2019,11,1),
                    Image="https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg",
                    GenreID=1
                 },
                  new Comic{ID=2, Name="Câu Chuyện Hồ Đồ",Status=0,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=100,Views=100,Update_time=new System.DateTime(2019,11,1),
                    Image="https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg",
                    GenreID=4
                 }
             };
            modelBuilder.Entity<Comic>().HasData(comics);              
            modelBuilder.Entity<Chapter>().HasData(chapters);

            var comments= new Comment[]
            {
                new Comment{
                    ID=1,CommentTime=new System.DateTime(2019,11,26),
                    Content="OK"
                },
                 new Comment{
                    ID=2,CommentTime=new System.DateTime(2019,11,26),
                    Content="OK"
                },
                 new Comment{
                    ID=3,CommentTime=new System.DateTime(2019,11,26),
                    Content="OK"
                }
            };
             modelBuilder.Entity<Comment>().HasData(comments);
             var posts= new Post[]
             {
                 new Post{
                     PostID=1,UserPostID=1,PostContent="Mn tim giup minh cuon truyen",
                     PostTime=new System.DateTime(2019,10,5),Title="Help me"

                 },
                  new Post{
                     PostID=2,UserPostID=2,PostContent="Mn tim giup minh cuon truyen",
                     PostTime=new System.DateTime(2019,10,5),Title="Help me"

                 }
             };
           // modelBuilder.Entity<Post>().HasData(posts);
            var likes= new Like[]
            {
                new Like{
                    ID=1,UserLikeID=1,check=true,ComicID=1
                },
                 new Like{
                    ID=2,UserLikeID=3,check=true,ComicID=1
                }
            };
            //modelBuilder.Entity<Like>().HasData(likes);
            // var answers= new Answer[]
            // {
            //     new Answer{
            //         AnswerID=1,AnswerTime=new System.DateTime(2019,2,22),
            //         UserAnswerID=2,Content="NE ............",PostID=1
            //     },
            //     new Answer{
            //         AnswerID=2,AnswerTime=new System.DateTime(2019,2,22),
            //         UserAnswerID=1,Content="NE ............",PostID=2
            //     }
            // };
            // modelBuilder.Entity<Answer>().HasData(answers);      
       }
     
     
    }
}