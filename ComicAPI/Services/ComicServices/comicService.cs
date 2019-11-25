using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;
using ComicAPI.Services.ComicServices;

namespace ComicAPI.Services.ComicServices
{
    public class comicService:IComicService
    {
        private DataContext _context;
        public comicService(DataContext context)
        {
            _context=context;
        }

        public void AddNewComic(Comic comic)
        {
            _context.Comics.Add(comic);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public void DeleteComic(int id)
        {
             var comic=_context.Comics.FirstOrDefault(x=>x.ID==id);
            _context.Comics.Remove(comic);
             _context.SaveChanges();
            throw new NotImplementedException();
        }

        public Comic GetComicById(int Id)
        {
            return _context.Comics.FirstOrDefault(x=> x.ID==Id);
            throw new NotImplementedException();
        }
        
        public List<Comic> GetComics()
        {
            var comics= new List<Comic>();
            comics=_context.Comics.ToList();
            return comics;
            throw new NotImplementedException();
        }

        public List<Comic> SearchByName(string keyword)
        {
            var comics= new List<Comic>();
            comics=_context.Comics.Where(x=>x.Name.Contains(keyword)).ToList();
            return comics;
            throw new NotImplementedException();
        }

        public void UpdateComic(int id, Comic comic_)
        {
            var comic = _context.Comics.FirstOrDefault(x=>x.ID==id);
            comic.Name=comic_.Name;
            comic.Status=comic_.Status;
            comic.Views=comic_.Views;
            comic.Likes=comic_.Likes;
            comic.Image=comic_.Image;
            comic.Update_time=comic_.Update_time;
            comic.Author=comic_.Author;
            comic.Chapter_long=comic_.Chapter_long;
            comic.GenreID=comic_.GenreID;
            comic.Description=comic_.Description;
            throw new NotImplementedException();
        }
    }
}