using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services.DataContext;

namespace ThemeParkManagementSystem.Services
{
    public class TicketSQLRepository : ITicketServices
    {
        private readonly TPMSDbContext context;

        public TicketSQLRepository(TPMSDbContext context)
        {
            this.context = context;
        }

        public Ticket AddTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return ticket;
        }

        public string RemoveTicket(int id)
        {
            context.Tickets.Remove(GetTicket(id));
            context.SaveChanges();
            return "Ticket Deleted.";
        }

        public Ticket GetTicket(int id)
        {
            return context.Tickets.FirstOrDefault(s => s.Id == id);
        }

        public List<Ticket> GetTickets()
        {
            return context.Tickets.ToList();
        }

        public Ticket UpdateTicket(Ticket updateTicket)
        {
            context.Tickets.Update(updateTicket);
            context.SaveChanges();
            return updateTicket;
        }

        public List<Ticket> GetTypeTickets(TicketTypes type)
        {
            return context.Tickets.Where(s => s.Type == type).ToList();
        }
    }
}