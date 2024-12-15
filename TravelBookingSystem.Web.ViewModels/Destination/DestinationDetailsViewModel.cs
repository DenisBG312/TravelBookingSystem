using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingSystem.Data.Models;

namespace TravelBookingSystem.Web.ViewModels.Destination
{
    public class DestinationDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string UserProfileImageUrl { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal PricePerNight { get; set; }
        public double Rating { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
