using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.Data
{
    public class IdentityDBContext: IdentityDbContext<IdentityUser>
    {
        public IdentityDBContext(DbContextOptions<IdentityDBContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }   
    }
}
