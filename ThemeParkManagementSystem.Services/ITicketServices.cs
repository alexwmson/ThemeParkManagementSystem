using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// ITicketServices
    /// Author: Javier
    /// Date: 2025-11-30
    /// Description: Defines business operations related to tickets (CRUD and filtering).
    /// </summary>
    
    public interface ITicketServices
    {
        // Gets all tickets
        List<Ticket> GetTickets();

        // Gets a ticket by its ID
        Ticket GetTicket(int id);

        // Removes a ticket by its ID
        string RemoveTicket(int id);

        // Adds a new ticket
        Ticket AddTicket(Ticket ticket);

        // Updates an existing ticket
        Ticket UpdateTicket(Ticket updateTicket);

        // Gets tickets filtered by type
        List<Ticket> GetTypeTickets(TicketTypes type);
    }
}
