using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicAPI.Models.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content{get;set;}
        public DateTime CommentTime{get;set;}

    //    public ICollection<RepComment> RepComments{get;set;}
        public User User{get;set;}
        public Comic Comic{get;set;}
    }
}