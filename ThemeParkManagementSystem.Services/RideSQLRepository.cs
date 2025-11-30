using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services.DataContext;

namespace ThemeParkManagementSystem.Services
{
    // Repository class implementing ride-related services using SQL database in the Theme Park Management System

    public class RideSQLRepository : IRideServices
    {
        private readonly TPMSDbContext context;

        public RideSQLRepository(TPMSDbContext context)
        {
            this.context = context;
        }

        public Ride AddRide(Ride ride)
        {
            context.Rides.Add(ride);
            context.SaveChanges();
            return ride;
        }

        public string RemoveRide(int id)
        {
            context.Rides.Remove(GetRide(id));
            context.SaveChanges();
            return "Ride Deleted.";
        }

        public Ride GetRide(int id)
        {
            return context.Rides.FirstOrDefault(s => s.Id == id);
        }

        public List<Ride> GetRides()
        {
            return context.Rides.ToList();
        }

        public Ride UpdateRide(Ride updateRide)
        {
            context.Rides.Update(updateRide);
            context.SaveChanges();
            return updateRide;
        }

        public int GetWaitTime(int id)
        {
            return context.Rides.FirstOrDefault(s => s.Id == id).WaitTime;
        }

        public List<Ride> GetRidesByWaitTime(int waittime)
        {
            return context.Rides.Where(s => s.WaitTime <= waittime).ToList();
        }
    }
}