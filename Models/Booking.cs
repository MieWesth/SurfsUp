using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace SurfsUp.Models
{
    [Table("Bookings", Schema = "SurfsUp")]
    public class Booking
    {
        public int BookingId { get; set; }

        [AllowNull]
        public int BoardId { get; set; }

        [AllowNull]
        public Board Board { get; set; } // Navigation property to link to the Board
        [AllowNull]
        [ForeignKey(nameof(Wetsuit))]
        public int WetsuitId { get; set; }
        [AllowNull]
        public WetsuitSize? WetsuitSize { get; set; }
        [AllowNull]
        public Wetsuit Wetsuit { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        public bool IsConfirmed { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
