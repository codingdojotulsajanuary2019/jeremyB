using System;
using Microsoft.EntityFrameworkCore;

namespace weddingPlanner.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Wedding> Weddings {get;set;}
        public DbSet<Guest> Guests {get;set;}
    }
}