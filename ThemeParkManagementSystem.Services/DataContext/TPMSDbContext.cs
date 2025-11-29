using Microsoft.EntityFrameworkCore;
using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services.DataContext
{
    public class TPMSDbContext : DbContext
    {
        public TPMSDbContext(DbContextOptions<TPMSDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
