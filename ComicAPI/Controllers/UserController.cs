using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComicAPI.Services.UserService;
using ComicAPI.Models.Entities;

namespace ComicAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
         private IUserService _userService;
          public UserController (IUserService userService)
        {
            _userService= userService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return  _userService.GetUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.AddNewUser(user);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userService.UpdateUser(id,user);
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}