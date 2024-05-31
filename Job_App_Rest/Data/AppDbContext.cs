using Job_App_Rest.Models;
using Microsoft.EntityFrameworkCore;

namespace Job_App_Rest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
        
            
            public DbSet<Company> CompanyTb { get; set; }
            public DbSet<Job> JobTb { get; set; }
        
    }
}
