using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBookingSystem.Data;
using TravelBookingSystem.Web.ViewModels.Destination;

namespace TravelBookingSystem.Web.Controllers
{
    public class Destination(ApplicationDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var destinations = await context.Destinations.ToListAsync();

            List<DestinationIndexViewModel> destinationViewModels = destinations.Select(d => new DestinationIndexViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Description = d.Description,
                ImageUrl = d.ImageUrl
            }).ToList(); 
            
            return View(destinationViewModels);
        }

        public IActionResult Details(int id)
        {
            throw new NotImplementedException();
        }
    }
}
