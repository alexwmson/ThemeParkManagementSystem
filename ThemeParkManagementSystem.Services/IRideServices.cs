using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
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
