using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services.DataContext;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// RideSQLRepository
    /// Author: Alex
    /// Date: 2025-11-30
    /// Description: Implements IRideServices using Entity Framework Core and TPMSDbContext.
    /// Handles CRUD and filter operations for Ride entities.
    /// </summary>

    public class RideSQLRepository : IRideServices
    {
        // Database context for accessing Ride data
        private readonly TPMSDbContext context;

        // Initializes a new instance of the RideSQLRepository class with the specified database context
        public RideSQLRepository(TPMSDbContext context)
        {
            this.context = context;
        }

        // Adds a new Ride to the database
        public Ride AddRide(Ride ride)
        {
            context.Rides.Add(ride);
            context.SaveChanges();
            return ride;
        }

        // Removes a Ride from the database by its ID
        public string RemoveRide(int id)
        {
            context.Rides.Remove(GetRide(id));
            context.SaveChanges();
            return "Ride Deleted.";
        }

        // Retrieves a Ride from the database by its ID
        public Ride GetRide(int id)
        {
            return context.Rides.FirstOrDefault(s => s.Id == id);
        }

        // Retrieves all Rides from the database
        public List<Ride> GetRides()
        {
            return context.Rides.ToList();
        }

        // Updates an existing Ride in the database
        public Ride UpdateRide(Ride updateRide)
        {
            context.Rides.Update(updateRide);
            context.SaveChanges();
            return updateRide;
        }

        // Retrieves the wait time for a Ride by its ID
        public int GetWaitTime(int id)
        {
            var ride = context.Rides.FirstOrDefault(r => r.Id == id);
            return ride?.WaitTime ?? 0;
        }

        // Retrieves Rides with a wait time less than or equal to the specified value
        public List<Ride> GetRidesByWaitTime(int waitTime)
        {
            return context.Rides.Where(s => s.WaitTime <= waitTime).ToList();
        }
    }
}