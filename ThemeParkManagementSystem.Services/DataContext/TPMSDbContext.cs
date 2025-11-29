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
        public DbSet<Ride> Rides { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, Name = "Alice Johnson", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2025, 12, 10), DatePurchased = new DateTime(2025, 12, 05) },
                new Ticket { Id = 2, Name = "Bobby Smith", Type = TicketTypes.Child, Price = 39.99f, ValidOn = new DateTime(2025, 12, 10), DatePurchased = new DateTime(2025, 12, 06) },
                new Ticket { Id = 3, Name = "Caroline Park", Type = TicketTypes.VIP, Price = 149.99f, ValidOn = new DateTime(2026, 01, 15), DatePurchased = new DateTime(2025, 12, 20) },
                new Ticket { Id = 4, Name = "David Nguyen", Type = TicketTypes.SeasonPass, Price = 299.99f, ValidOn = new DateTime(2026, 01, 01), DatePurchased = new DateTime(2025, 12, 03) },
                new Ticket { Id = 5, Name = "Emily Carter", Type = TicketTypes.FastPass, Price = 29.99f, ValidOn = new DateTime(2025, 12, 18), DatePurchased = new DateTime(2025, 12, 18) }
            );

            modelBuilder.Entity<Ride>().HasData(
                new Ride { Id = 1, Name = "Dragon Coaster", Description = "High-speed roller coaster", Capacity = 24, WaitTime = 45, NextMaintenance = new DateTime(2026, 01, 10) },
                new Ride { Id = 2, Name = "Splash Mountain", Description = "Log flume ride with drops", Capacity = 20, WaitTime = 30, NextMaintenance = new DateTime(2026, 02, 05) },
                new Ride { Id = 3, Name = "Sky Wheel", Description = "Giant ferris wheel with views", Capacity = 40, WaitTime = 15, NextMaintenance = new DateTime(2026, 03, 01) },
                new Ride { Id = 4, Name = "Haunted Mansion", Description = "Dark ride with animatronics", Capacity = 16, WaitTime = 25, NextMaintenance = new DateTime(2026, 04, 12) },
                new Ride { Id = 5, Name = "Rocket Launch", Description = "Vertical launch thrill ride", Capacity = 12, WaitTime = 60, NextMaintenance = new DateTime(2026, 01, 25) }
            );
        }
    }
}
