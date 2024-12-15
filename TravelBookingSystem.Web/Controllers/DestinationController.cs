using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBookingSystem.Data;
using TravelBookingSystem.Web.ViewModels.Destination;
using TravelBookingSystem.Data.Models;

namespace TravelBookingSystem.Web.Controllers
{
    public class DestinationController(ApplicationDbContext context) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var destinations = await context.Destinations.ToListAsync();

            List<DestinationIndexViewModel> destinationViewModels = destinations.Select(d => new DestinationIndexViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Country = d.Country,
                Description = d.Description,
                ImageUrl = d.ImageUrl
            }).ToList();

            return View(destinationViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Destination destination)
        {
            if (!ModelState.IsValid)
            {
                return View(destination);
            }

            await context.Destinations.AddAsync(destination);
            await context.SaveChangesAsync();


            return RedirectToAction("Index", "Destination");
        }
        public async Task<IActionResult> Details(int id)
        {
            var destination = await context.Destinations
                .Include(d => d.Reviews)
                .ThenInclude(r => r.User)
                .Include(d => d.Trips)
                .Where(d => d.Id == id)
                .Select(d => new DestinationDetailsViewModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Country = d.Country,
                    Description = d.Description,
                    ImageUrl = d.ImageUrl,
                    Rating = d.Reviews.Any()
                        ? (int)Math.Round(d.Reviews.Average(r => (double)r.Rating))
                        : 0,
                    Reviews = d.Reviews.ToList(),
                    Trips = d.Trips.ToList()
                })
                .FirstOrDefaultAsync();

            if (destination == null)
            {
                return RedirectToAction("Index", "Destination");
            }

            return View(destination);
        }
    }
}
