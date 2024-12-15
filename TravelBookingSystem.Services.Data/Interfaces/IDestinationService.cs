using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelBookingSystem.Data.Models;

namespace TravelBookingSystem.Services.Data.Interfaces
{
    public interface IDestinationService
    {
        Task<IEnumerable<Destination>> GetAllDestinations();
    }
}
