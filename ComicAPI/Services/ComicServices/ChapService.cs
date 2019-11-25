using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;

namespace ComicAPI.Services.ComicServices
{
    public class ChapService : IChapService
    {
        private DataContext _context;
        public ChapService(DataContext context)
        {
            _context=context;
        }
        public void AddChap(Chapter chap)
        {
            _context.Chapters.Add(chap);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public void DeleteChap(int id)
        {
            var chap= _context.Chapters.SingleOrDefault(x=> x.ChapterID==id);
            _context.Chapters.Remove(chap);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public Chapter GetChap(int chapid, int comicid)
        {
            throw new NotImplementedException();
        }

        public List<Chapter> GetChaps()
        {
            return _context.Chapters.ToList();
            throw new NotImplementedException();
        }

        public List<Chapter> GetChapsofComic(int comicid)
        {
             var chaps= new List<Chapter>();
            chaps= _context.Chapters.Where(x=>x.ComicID==comicid).ToList();
            return chaps;
            throw new NotImplementedException();
        }

        public void UpdateChap(int chapid, int comicid, Chapter chapter)
        {
            throw new NotImplementedException();
        }
    }
}