using TravelBookingSystem.Data;
using TravelBookingSystem.Data.Models;
using TravelBookingSystem.Services.Data.Interfaces;

namespace TravelBookingSystem.Services.Data
{
    public class DestinationService : IDestinationService
    {
        private readonly ApplicationDbContext _context;

        public DestinationService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<Destination>> GetAllDestinations()
        {
        }
    }
}
