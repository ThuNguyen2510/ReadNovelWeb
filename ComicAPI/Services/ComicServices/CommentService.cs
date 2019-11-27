using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;

namespace ComicAPI.Services.ComicServices
{
    public class CommentService : ICommentService
    {
        DataContext _context;
        public CommentService(DataContext context)
        {
            _context = context;
        }
        public void AddComment(Comment comment)
        {
            var User = _context.Users.Where(x=>x.ID==comment.User.ID).SingleOrDefault();
            _context.Comments.Add(comment);
            User.Comment.Add(comment);
            var Comic=_context.Comics.Where(x=>x.ID==comment.Comic.ID).SingleOrDefault();
            Comic.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void DeleteComment(int id)
        {
            _context.Comments.Remove(_context.Comments.FirstOrDefault(x=>x.ID==id));
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public Comment GetCommentById(int id)
        {
            var comment=_context.Comments.Select(c=> new Comment{
                ID = c.ID,
                Content = c.Content,
                User= new User{
                    ID=c.User.ID
                },
                Comic=new Comic{
                    ID=c.Comic.ID
                }
            }).Where(x=> x.ID==id).SingleOrDefault();
            return comment;
            throw new NotImplementedException();
        }

        public List<Comment> GetComments()
        {
            var listComm = _context.Comments.Select(c=>new Comment
            {
                ID = c.ID,
                Content = c.Content,
                User= new User{
                    ID=c.User.ID
                }
                // Comic=new Comic{
                //     ID=c.Comic.ID
                // }
                
            }).ToList();
            return listComm;

           // throw new NotImplementedException();
        }

        public void UpdateComment(int id, Comment comment)
        {
            var old = _context.Comments.SingleOrDefault(x=>x.ID==id);
            old.Content=comment.Content;
            old.CommentTime=comment.CommentTime;
            _context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}