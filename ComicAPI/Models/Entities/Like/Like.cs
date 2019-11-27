using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicAPI.Models.Entities
{
    public class Like
    {
        public int ID{get;set;}
        public int UserLikeID{get;set;}
        public int ComicID{get;set;}
        public Boolean check {get;set;}
         public User UserLike{get;set;}
    }
}