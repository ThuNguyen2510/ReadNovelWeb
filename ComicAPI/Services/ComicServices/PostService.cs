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
            User  user= _context.Users.FirstOrDefault(x=> x.ID==post.UserID);
            _context.Posts.Add(post);
            user.Posts.Add(post);
            _context.SaveChanges();
        }

        public void DeletePost(int id)
        {
            _context.Posts.Remove(_context.Posts.FirstOrDefault(x=>x.ID==id));
            _context.SaveChanges();
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
           Post post1= _context.Posts.FirstOrDefault(x=> x.ID==id);
           post1.PostContent=post.PostContent;
           post1.PostTime=post.PostTime;
           post1.Title=post.Title;
           _context.SaveChanges();
        }
    }
}