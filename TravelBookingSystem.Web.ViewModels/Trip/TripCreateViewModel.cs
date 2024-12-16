using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingSystem.Data.Models;
using TravelBookingSystem.Data.Models.Enums;

namespace TravelBookingSystem.Web.ViewModels.Trip
{
    public class TripCreateViewModel
    {
        [DisplayName("Destination")]
        public int DestinationId { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(1);
        public decimal Price { get; set; }
        public TripType TripType { get; set; }
        public int AvailableSeats { get; set; }
        public IEnumerable<Data.Models.Destination> Destinations { get; set; }
    }
}
