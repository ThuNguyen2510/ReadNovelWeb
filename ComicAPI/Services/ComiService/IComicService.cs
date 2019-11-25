using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;

namespace ComicAPI.Services.ComicService
{
    public interface IComicService
    {
        List<Comic> GetComics();
        Comic GetComicById(int Id);
        void AddNewComic(Comic comic);
        void UpdateComic(int id,Comic user);
        void DeleteComic(int id);
    }
}