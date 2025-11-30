using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// IRideServices
    /// Author: Alex
    /// Date: 2025-11-30
    /// Description: Defines business operations related to Rides (CRUD and filtering).
    /// </summary>
    public interface IRideServices
    {
        // Gets all rides
        List<Ride> GetRides();

        // Gets a ride by its ID
        Ride GetRide(int id);

        // Removes a ride by its ID
        string RemoveRide(int id);

        // Adds a new ride
        Ride AddRide(Ride ride);

        // Updates an existing ride
        Ride UpdateRide(Ride updateRide);

        // Gets the wait time for a specific ride by its ID
        int GetWaitTime(int id);

        // Gets rides filtered by wait time
        List<Ride> GetRidesByWaitTime(int waittime);
    }
}
