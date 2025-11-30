using System.ComponentModel.DataAnnotations;

namespace ThemeParkManagementSystem.Entities
{
    // Entity representing a Ticket in the Theme Park Management System

    public enum TicketTypes
    {
        Adult,
        Child,
        Senior,
        VIP,
        SeasonPass,
        FastPass
    }

    public static class TicketPricing
    {
        public static Dictionary<TicketTypes, float> TicketPrices() =>
            new Dictionary<TicketTypes, float>
            {
                { TicketTypes.Adult, 59.99f },
                { TicketTypes.Child, 39.99f },
                { TicketTypes.Senior, 49.99f },
                { TicketTypes.VIP, 149.99f },
                { TicketTypes.SeasonPass, 299.99f },
                { TicketTypes.FastPass, 89.99f }
            };
    }

    public class Ticket
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public TicketTypes Type { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public DateTime ValidOn { get; set; }
        [Required]
        public DateTime DatePurchased { get; set; }
    }
}
