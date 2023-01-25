using CheckGroup.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckGroup.Data.Basa
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {
            
        }
        DbSet<Student> Students { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Group> Groups { get; set; }
    }
}
