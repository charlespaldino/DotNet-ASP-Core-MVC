using ExploreCalifornia.Models;
using ExploreCalifornia.Models.Tours;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ExploreCalifornia.Data
{
    public class ExploreDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<MonthlySpecial> MonthlySpecials { get; set; }

        public DbSet<TriviaFact> TriviaFacts { get; set; }
        public DbSet<Tour> Tours { get; set; }


        public ExploreDBContext(DbContextOptions<ExploreDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
