using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooReviewDotComII.Models;

namespace ZooReviewDotComII.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Zoo> Zoos {  get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
