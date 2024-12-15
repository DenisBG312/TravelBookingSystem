using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBookingSystem.Data.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = null!;
        [Required]
        [MaxLength(300)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int DestinationId { get; set; }
        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; }
        public decimal PricePerNight { get; set; }
        public int StarRating { get; set; }

        public ICollection<Room> Rooms { get; set; } = new HashSet<Room>();
    }
}
