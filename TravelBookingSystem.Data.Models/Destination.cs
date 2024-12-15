using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TravelBookingSystem.Data.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(60)]
        public string Country { get; set; } = null!;
        [Required]
        [MaxLength(300)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;

        public ICollection<Trip> Trips { get; set; } = new HashSet<Trip>();
        public ICollection<Hotel> Hotels { get; set; } = new HashSet<Hotel>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
    }
}
