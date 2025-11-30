using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    // Interface defining ride-related services in the Theme Park Management System

    public interface IRideServices
    {
        List<Ride> GetRides();
        Ride GetRide(int id);

        string RemoveRide(int id);
        Ride AddRide(Ride ride);
        Ride UpdateRide(Ride updateRide);

        int GetWaitTime(int id);

        List<Ride> GetRidesByWaitTime(int waittime);
    }
}
