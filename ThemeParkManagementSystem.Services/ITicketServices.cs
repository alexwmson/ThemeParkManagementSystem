using ThemeParkManagementSystem.Entities;

namespace ThemeParkManagementSystem.Services
{
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
