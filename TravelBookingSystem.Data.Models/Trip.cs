using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingSystem.Data.Models.Enums;

namespace TravelBookingSystem.Data.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DestinationId { get; set; }
        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int AvailableSeats { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Price { get; set; }
        [Required]
        public TripType TripType { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
