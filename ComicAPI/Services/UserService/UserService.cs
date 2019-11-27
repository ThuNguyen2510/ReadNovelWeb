using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;

namespace ComicAPI.Services.UserService
{
    public class UserService :IUserService
    {
       private DataContext _context;
        public UserService(DataContext context)
        {
            _context= context;
        }

        public void AddNewUser(User user)
        {
             _context.Users.Add(user);
            _context.SaveChanges();
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
             var user=_context.Users.FirstOrDefault(x=>x.ID==id);
            _context.Users.Remove(user);
             _context.SaveChanges();
            throw new NotImplementedException();
        }

        public User GetUserById(int Id)
        {
            return _context.Users.Select(u=> new User{
                ID=u.ID,
                Username=u.Username,
                Password=u.Password,
                Image=u.Image,
                Email=u.Email,Role=u.Role,
                Comment=u.Comment.Select(e=> new Comment
                {
                    ID = e.ID,
                   Content= e.Content,CommentTime=e.CommentTime,Comic= new Comic{ID=e.Comic.ID}
                }).ToList()
            }).Where(x=> x.ID==Id).SingleOrDefault();
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {      
            var users= new List<User>();
            users=_context.Users.ToList();
            return users;
            throw new NotImplementedException();
        }

        public void UpdateUser(int id, User user)
        {
            var olduser=_context.Users.FirstOrDefault(x=>x.ID==id);
            olduser.Password=user.Password;
            olduser.Username=user.Username;
            olduser.Email=user.Email;
            olduser.Role=user.Role;
            _context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}