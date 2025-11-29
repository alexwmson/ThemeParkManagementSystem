using System.ComponentModel.DataAnnotations;

namespace ThemeParkManagementSystem.Entities
{
    public enum TicketTypes
    {
        Adult,
        Child,
        Senior,
        VIP,
        SeasonPass,
        FastPass
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
