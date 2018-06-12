using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.BusinessInterfaces
{
    using Types;

    public interface IFlightsProcessor
    {
        Task<IEnumerable<FlightDto>> GetAll();
    }
}
