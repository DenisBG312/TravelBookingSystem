using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelBookingSystem.Web.ViewModels.Destination
{
    public class DestinationIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
