using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBookingSystem.Web.ViewModels.Trip
{
    public class TripIndexViewModel
    {
        public int Id { get; set; }
        public string DestinationName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string TripType { get; set; }
    }
}
