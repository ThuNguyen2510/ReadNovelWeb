using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ComicAPI
{
    public static class DbInit
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService< DbContextOptions<DataContext>>()))
            {
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            var users = new User[]
            {
                new User { Username = "NhutThuy",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User { Username = "TuongVi",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User { Username = "Admin",   Email = "admin@gmail.com",
                Password="12345",Role=1
                    },
                     new User { Username = "User3",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User { Username = "User3",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User { Username = "User3",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
                     new User { Username = "User3",   Email = "user@gmail.com",
                Password="12345",Role=0
                    },
            };

            foreach (User s in users)
            {
                context.Users.AddRange(s);
            }
            context.SaveChanges();
        }
    }
    }
}