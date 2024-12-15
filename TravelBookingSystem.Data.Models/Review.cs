using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBookingSystem.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DestinationId { get; set; }
        [ForeignKey(nameof(DestinationId))]
        public Destination Destination { get; set; }
        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        [MaxLength(300)]
        public string Comment { get; set; } = null;
        [Required]
        public DateTime ReviewDate { get; set; } = DateTime.Now;    
    }
}
