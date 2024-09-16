using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurfsUp.Models
{
    [Table("Bookings", Schema = "SurfsUp")]
    public class Booking
    {
        public int BookingId { get; set; }

        [Required]
        public int BoardId { get; set; }

        public Board Board { get; set; } // Navigation property to link to the Board

        [Required]
        public DateTime DateFrom { get; set; }

        [Required]
        public DateTime DateTo { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
