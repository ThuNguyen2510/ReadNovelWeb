using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;

namespace ComicAPI.Services
{
    public class PostService : IPostService
    {
        DataContext _context;
        public PostService(DataContext context)
        {
            _context=context;
        }
        public void AddPost(Post post)
        {
            
        }

        public void DeletePost(int id)
        {
            
        }

        public Post GetPostByID(int id)
        {
           return _context.Posts.Where(x=>x.ID==id).SingleOrDefault();
        }

        public List<Post> GetPosts()
        {
            List<Post> posts = _context.Posts.ToList();
            return posts;

        }

        public void UpdatePost(int id, Post post)
        {
            throw new NotImplementedException();
        }
    }
}