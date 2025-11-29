using System.ComponentModel.DataAnnotations;

namespace ThemeParkManagementSystem.Entities
{
    public class Ride
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int WaitTime { get; set; } // in minutes
        public DateTime NextMaintenance {  get; set; } // not required because maintenance might not be scheduled yet


    }
}
