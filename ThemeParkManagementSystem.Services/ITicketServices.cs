using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
    // Interface defining ticket-related services in the Theme Park Management System

    public interface ITicketServices
    {
        List<Ticket> GetTickets();
        Ticket GetTicket(int id);

        string RemoveTicket(int id);
        Ticket AddTicket(Ticket ticket);
        Ticket UpdateTicket(Ticket updateTicket);

        List<Ticket> GetTypeTickets(TicketTypes type);
    }
}
