using ThemeParkManagementSystem.Entities;
using ThemeParkManagementSystem.Services.DataContext;

namespace ThemeParkManagementSystem.Services
{
    /// <summary>
    /// TicketSQLRepository
    /// Author: Javier
    /// Date: 2025-11-30
    /// Description: Implements ITicketServices using Entity Framework Core and TPMSDbContext.
    /// Handles CRUD and filter operations for Ticket entities.
    /// </summary>
    
    public class TicketSQLRepository : ITicketServices
    {
        // Database context for Theme Park Management System
        private readonly TPMSDbContext context;

        // Initializes a new instance of the TicketSQLRepository class with the specified database context
        public TicketSQLRepository(TPMSDbContext context)
        {
            this.context = context;
        }

        // Adds a new ticket to the database
        public Ticket AddTicket(Ticket ticket)
        {
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return ticket;
        }

        // Removes a ticket from the database by its ID
        public string RemoveTicket(int id)
        {
            context.Tickets.Remove(GetTicket(id));
            context.SaveChanges();
            return "Ticket Deleted.";
        }

        // Retrieves a ticket from the database by its ID
        public Ticket GetTicket(int id)
        {
            return context.Tickets.FirstOrDefault(s => s.Id == id);
        }

        // Retrieves all tickets from the database
        public List<Ticket> GetTickets()
        {
            return context.Tickets.ToList();
        }

        // Updates an existing ticket in the database
        public Ticket UpdateTicket(Ticket updateTicket)
        {
            context.Tickets.Update(updateTicket);
            context.SaveChanges();
            return updateTicket;
        }

        // Gets tickets of a specific type from the database
        public List<Ticket> GetTypeTickets(TicketTypes type)
        {
            return context.Tickets.Where(s => s.Type == type).ToList();
        }
    }
}