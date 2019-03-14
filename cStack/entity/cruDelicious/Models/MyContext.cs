using Microsoft.EntityFrameworkCore;
 
namespace cruDelicious.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter alongcopy
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
    }
}