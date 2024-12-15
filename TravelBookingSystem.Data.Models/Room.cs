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
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,6)")]
        public decimal PricePerNight { get; set; }
        [Required]
        public int HotelId { get; set; }
        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
    }
}
