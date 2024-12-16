using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TravelBookingSystem.Data;
using TravelBookingSystem.Data.Models;
using TravelBookingSystem.Data.Models.Enums;
using TravelBookingSystem.Web.ViewModels.Trip;

namespace TravelBookingSystem.Web.Controllers
{
    public class TripController : Controller
    {
        private readonly ApplicationDbContext _context;
        public TripController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            var trips = await _context.Trips
                .Include(t => t.Destination)
                .ToListAsync();

            var viewModel = trips.Select(t => new TripIndexViewModel
            {
                Id = t.Id,
                DestinationName = t.Destination.Name,
                StartDate = t.StartDate,
                EndDate = t.EndDate,
                Price = t.Price,
                TripType = t.TripType.ToString()
            }).ToList();

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var destinations = await _context.Destinations.ToListAsync();
            var viewModel = new TripCreateViewModel
            {
                Destinations = destinations
            };
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TripCreateViewModel model)
        {
            ModelState.Remove(nameof(model.Destinations));

            if (!ModelState.IsValid)
            {
                var destinations = await _context.Destinations.ToListAsync();
                model.Destinations = destinations;
                return View(model);
            }

            var trip = new Trip
            {
                DestinationId = model.DestinationId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                AvailableSeats = model.AvailableSeats,
                Price = model.Price,
                TripType = model.TripType   
            };

            await _context.Trips.AddAsync(trip);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var trip = await _context.Trips
                .Include(t => t.Destination)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (trip == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var viewModel = new TripDetailsViewModel
            {
                Id = trip.Id,
                DestinationName = trip.Destination.Name,
                StartDate = trip.StartDate,
                EndDate = trip.EndDate,
                Price = trip.Price,
                TripType = trip.TripType
            };

            return View(viewModel);
        }
    }
}
