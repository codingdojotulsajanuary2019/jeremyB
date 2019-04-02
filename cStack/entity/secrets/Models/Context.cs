using System;
using Microsoft.EntityFrameworkCore;

namespace secrets.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Secret> Secrets {get;set;}
        public DbSet<Like> Likes {get;set;}
    }
}