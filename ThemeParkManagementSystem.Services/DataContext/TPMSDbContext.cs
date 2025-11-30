using Microsoft.EntityFrameworkCore;
using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services.DataContext
{
    /// <summary>
    /// TPMSDbContext
    /// Author: Alex / Javier
    /// Date: 2025-11-30
    /// Description: Entity Framework Core database context for the Theme Park Management System.
    /// Manages Ticket and Ride entities and seeds initial sample data for analytics and testing.
    /// </summary>
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
                new Ticket { Id = 5, Name = "Emily Carter", Type = TicketTypes.FastPass, Price = 89.99f, ValidOn = new DateTime(2025, 12, 18), DatePurchased = new DateTime(2025, 12, 18) },

                new Ticket { Id = 6, Name = "Franklin West", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2025, 12, 19), DatePurchased = new DateTime(2025, 12, 19) },
                new Ticket { Id = 7, Name = "Grace Howard", Type = TicketTypes.VIP, Price = 149.99f, ValidOn = new DateTime(2025, 12, 20), DatePurchased = new DateTime(2025, 12, 19) },
                new Ticket { Id = 8, Name = "Henry Lopez", Type = TicketTypes.Child, Price = 39.99f, ValidOn = new DateTime(2025, 12, 22), DatePurchased = new DateTime(2025, 12, 21) },
                new Ticket { Id = 9, Name = "Isabella Turner", Type = TicketTypes.FastPass, Price = 89.99f, ValidOn = new DateTime(2025, 12, 22), DatePurchased = new DateTime(2025, 12, 22) },
                new Ticket { Id = 10, Name = "Jacob Hill", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2025, 12, 23), DatePurchased = new DateTime(2025, 12, 23) },

                new Ticket { Id = 11, Name = "Kelly Green", Type = TicketTypes.Senior, Price = 49.99f, ValidOn = new DateTime(2025, 12, 24), DatePurchased = new DateTime(2025, 12, 24) },
                new Ticket { Id = 12, Name = "Liam Roberts", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2025, 12, 25), DatePurchased = new DateTime(2025, 12, 25) },
                new Ticket { Id = 13, Name = "Mia Douglas", Type = TicketTypes.VIP, Price = 149.99f, ValidOn = new DateTime(2026, 01, 03), DatePurchased = new DateTime(2025, 12, 26) },
                new Ticket { Id = 14, Name = "Noah Carter", Type = TicketTypes.Child, Price = 39.99f, ValidOn = new DateTime(2025, 12, 26), DatePurchased = new DateTime(2025, 12, 26) },
                new Ticket { Id = 15, Name = "Olivia Brooks", Type = TicketTypes.FastPass, Price = 89.99f, ValidOn = new DateTime(2026, 01, 05), DatePurchased = new DateTime(2025, 12, 27) },

                new Ticket { Id = 16, Name = "Peter Winston", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2026, 01, 06), DatePurchased = new DateTime(2025, 12, 28) },
                new Ticket { Id = 17, Name = "Quinn Adams", Type = TicketTypes.Senior, Price = 49.99f, ValidOn = new DateTime(2026, 01, 07), DatePurchased = new DateTime(2025, 12, 29) },
                new Ticket { Id = 18, Name = "Rebecca Miles", Type = TicketTypes.VIP, Price = 149.99f, ValidOn = new DateTime(2026, 01, 08), DatePurchased = new DateTime(2025, 12, 30) },
                new Ticket { Id = 19, Name = "Samuel Pratt", Type = TicketTypes.Child, Price = 39.99f, ValidOn = new DateTime(2026, 01, 09), DatePurchased = new DateTime(2025, 12, 30) },
                new Ticket { Id = 20, Name = "Tiffany Rhodes", Type = TicketTypes.FastPass, Price = 89.99f, ValidOn = new DateTime(2026, 01, 10), DatePurchased = new DateTime(2025, 12, 31) },

                new Ticket { Id = 21, Name = "Franklin Moore", Type = TicketTypes.Adult, Price = 59.99f, ValidOn = new DateTime(2025, 12, 01), DatePurchased = new DateTime(2025, 12, 01) },
                new Ticket { Id = 22, Name = "Georgia Alvarez", Type = TicketTypes.Child, Price = 39.99f, ValidOn = new DateTime(2025, 12, 01), DatePurchased = new DateTime(2025, 12, 01) },
                new Ticket { Id = 23, Name = "Henry Thompson", Type = TicketTypes.FastPass, Price = 89.99f, ValidOn = new DateTime(2025, 12, 01), DatePurchased = new DateTime(2025, 12, 01) }
            );

            modelBuilder.Entity<Ride>().HasData(
                new Ride { Id = 1, Name = "Dragon Coaster", Description = "High-speed roller coaster", Capacity = 24, WaitTime = 45, NextMaintenance = new DateTime(2026, 01, 10) },
                new Ride { Id = 2, Name = "Splash Mountain", Description = "Log flume ride with drops", Capacity = 20, WaitTime = 30, NextMaintenance = new DateTime(2026, 02, 05) },
                new Ride { Id = 3, Name = "Sky Wheel", Description = "Giant ferris wheel with views", Capacity = 40, WaitTime = 15, NextMaintenance = new DateTime(2026, 03, 01) },
                new Ride { Id = 4, Name = "Haunted Mansion", Description = "Dark ride with animatronics", Capacity = 16, WaitTime = 25, NextMaintenance = new DateTime(2026, 04, 12) },
                new Ride { Id = 5, Name = "Rocket Launch", Description = "Vertical launch thrill ride", Capacity = 12, WaitTime = 60, NextMaintenance = new DateTime(2026, 01, 25) },

                new Ride { Id = 6, Name = "Jungle Expedition", Description = "Boat safari adventure", Capacity = 30, WaitTime = 40, NextMaintenance = new DateTime(2026, 05, 02) },
                new Ride { Id = 7, Name = "Pirate Bay", Description = "Water boat battle ride", Capacity = 28, WaitTime = 35, NextMaintenance = new DateTime(2026, 04, 20) },
                new Ride { Id = 8, Name = "Galactic Spin", Description = "Spinning space-themed ride", Capacity = 18, WaitTime = 20, NextMaintenance = new DateTime(2026, 02, 14) },
                new Ride { Id = 9, Name = "Wild River Rapids", Description = "Fast-paced river rafting", Capacity = 25, WaitTime = 55, NextMaintenance = new DateTime(2026, 06, 01) },
                new Ride { Id = 10, Name = "Mystery Mine", Description = "Indoor mine-cart roller coaster", Capacity = 22, WaitTime = 50, NextMaintenance = new DateTime(2026, 07, 09) },

                new Ride { Id = 11, Name = "Sky Glider", Description = "Aerial gondola with aerial views", Capacity = 40, WaitTime = 10, NextMaintenance = new DateTime(2026, 03, 20) },
                new Ride { Id = 12, Name = "Tornado Twister", Description = "Extreme spinning thrill ride", Capacity = 14, WaitTime = 65, NextMaintenance = new DateTime(2026, 01, 28) },
                new Ride { Id = 13, Name = "Firestorm Drop", Description = "Tower drop ride", Capacity = 16, WaitTime = 70, NextMaintenance = new DateTime(2026, 02, 11) },
                new Ride { Id = 14, Name = "Enchanted Carousel", Description = "Classic carousel with fantasy theme", Capacity = 50, WaitTime = 5, NextMaintenance = new DateTime(2026, 03, 01) },
                new Ride { Id = 15, Name = "Cosmic Cruiser", Description = "Motion simulator space ride", Capacity = 30, WaitTime = 45, NextMaintenance = new DateTime(2026, 04, 02) },

                new Ride { Id = 16, Name = "Ice Cavern Escape", Description = "Dark ride through frozen tunnels", Capacity = 20, WaitTime = 25, NextMaintenance = new DateTime(2026, 05, 25) },
                new Ride { Id = 17, Name = "Volcano Surge", Description = "High-speed volcanic themed coaster", Capacity = 18, WaitTime = 90, NextMaintenance = new DateTime(2026, 06, 10) },
                new Ride { Id = 18, Name = "Alien Encounter", Description = "Sci-fi dark ride with animatronics", Capacity = 14, WaitTime = 35, NextMaintenance = new DateTime(2026, 07, 01) },
                new Ride { Id = 19, Name = "Jungle Flyers", Description = "Zip-line glider attraction", Capacity = 12, WaitTime = 80, NextMaintenance = new DateTime(2026, 05, 10) },
                new Ride { Id = 20, Name = "Crystal Caverns", Description = "Slow exploration dark ride", Capacity = 20, WaitTime = 18, NextMaintenance = new DateTime(2026, 06, 15) }
            );
        }

    }
}
