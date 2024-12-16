using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingSystem.Data.Models.Enums;

namespace TravelBookingSystem.Web.ViewModels.Trip
{
    public class TripDetailsViewModel
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public TripType TripType { get; set; }
    }
}
