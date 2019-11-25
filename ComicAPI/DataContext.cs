using Microsoft.EntityFrameworkCore;
using ComicAPI.Models.Entities;
using System.Linq;

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

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Chapter>().ToTable("Chapter");
            modelBuilder.Entity<Comic>().ToTable("Comic");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<ComicGenre>().ToTable("ComicGenre");
            modelBuilder.Entity<ComicGenre>().HasKey(c=> new {c.ComicID,c.GenreID});
            modelBuilder.Entity<User>().HasData(
                 new User { ID=1, Username = "ThuNguyen",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                 new User { ID=2, Username = "NhutThuy",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User {ID=3,Username = "TuongVi",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User {ID=4, Username = "Admin",   Email = "admin@gmail.com",
                Password="12345",Role=1
                    }
             );
             var genres= new Genre[]
             {
                new Genre{ GenreID=1,Genre_name="Trinh Thám" },
                new Genre{ GenreID=2,Genre_name="Ngôn Tình" },
                new Genre{ GenreID=3,Genre_name="Viễn Tưởng" },
                new Genre{ GenreID=4,Genre_name="Xuyên Không" },
                new Genre{ GenreID=5,Genre_name="Dị Giới" }
             };
             modelBuilder.Entity<Genre>().HasData(genres);
             var comics=new Comic[]
             {
                  new Comic{ID=1, Name="Công Cuộc Bị 999 Em Gái Chinh Phục",Status=0,Author="Đỗ Cầm",
                    Description=" Sẽ thế nào khi bạn mang trong người song tu thần kinh? Sở hữu khả năng xuyên qua 10 thế giới? Đào hoa vận không thua gì Rito (To love ru)? Lập 1 giàn harem, thủy tinh cung khủng nhất vũ trụ về khoe cho bọn bạn gato chơi.Đỗ Cầm có tất cả nhưng lại thừa 1 điều..... thừa bóng ma tâm lý về phụ nữ.Hãy đón xem công cuộc bị chinh phục của anh chàng đen đủi hay may mắn này nhé",
                    Chapter_long=0,Likes=100,Views=100,Update_time=new System.DateTime(2019,11,1),
                    Image="https://sstruyen.com/assets/img/story//cong-cuoc-bi-em-gai-chinh-phuc.jpg"
                 },
                  new Comic{ID=2, Name="Câu Chuyện Hồ Đồ",Status=0,Author="Phong Tử Tam Tam",
                  Description="Cố Minh Sâm giúp Ôn Vãn, lại không ngờ con bé kia lấy oán trả ơn.Mà Ôn Vãn không thẹn với lòng, dám khẳng định: Cô đối với Cố Minh Sâm, chỉ còn kém việc, dâng cái mạng nhỏ này cho anh ta. Kết quả chỉ đổi lấy tờ giấy thỏa thuận li hôn. Quả nhiên, thế giới này vô cùng bất công, người tốt lại chẳng được đền đáp.Dùng một câu để chốt văn án: Kết thúc đoạn hôn nhân hữu danh vô thực  đáng thất vọng, vận đào hoa của Ôn Vãn bỗng nhiên khởi sắc.",
                  Chapter_long=0,Likes=100,Views=100,Update_time=new System.DateTime(2019,11,1),
                    Image="https://sstruyen.com/assets/img/story//cau-chuyen-ho-o.jpg"
                 }
             };
             modelBuilder.Entity<Comic>().HasData(comics);
             var comicgenres=new ComicGenre[]
             {
                new ComicGenre{
                     ComicID=comics.Single(c=>c.Name=="Công Cuộc Bị 999 Em Gái Chinh Phục").ID,
                     GenreID=genres.Single(d=> d.Genre_name=="Ngôn Tình").GenreID
                 },
                new ComicGenre{
                     ComicID=comics.Single(c=>c.Name=="Công Cuộc Bị 999 Em Gái Chinh Phục").ID,
                     GenreID=genres.Single(d=> d.Genre_name=="Trinh Thám").GenreID
                 },
                 new ComicGenre{
                     ComicID=comics.Single(c=>c.Name=="Câu Chuyện Hồ Đồ").ID,
                     GenreID=genres.Single(d=> d.Genre_name=="Dị Giới").GenreID
                 },
                 new ComicGenre{
                     ComicID=comics.Single(c=>c.Name=="Câu Chuyện Hồ Đồ").ID,
                     GenreID=genres.Single(d=> d.Genre_name=="Viễn Tưởng").GenreID
                 },
             };
             modelBuilder.Entity<ComicGenre>().HasData(comicgenres);
             var chapters =new Chapter[]
             {
                 new Chapter{
                     ChapterID=1,ComicId=1,Title="Đỗ Mạnh Cầm",STT=1,
                     Content=   ""
                 },
                  new Chapter{
                     ChapterID=2,ComicId=1,Title="Khổ luyện",STT=2,
                     Content= ""  },
                  new Chapter{
                     ChapterID=3,ComicId=2,Title="Bộ mặt thật của 3 bà chị",STT=1,
                     Content="" },
                  new Chapter{
                     ChapterID=4,ComicId=2,Title="Xui Kiếp",STT=2,
                     Content=""  }
             };
            modelBuilder.Entity<Chapter>().HasData(chapters);
       }
     
     
    }
}