using Microsoft.EntityFrameworkCore;
using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services.DataContext
{
    public class TPMSDbContext : DbContext
    {
        public TPMSDbContext(DbContextOptions<TPMSDbContext> option) : base(option)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}
