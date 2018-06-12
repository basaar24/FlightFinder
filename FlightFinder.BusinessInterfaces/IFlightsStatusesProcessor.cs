using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.BusinessInterfaces
{
    using Types;

    public interface IFlightsStatusesProcessor
    {
        Task<IEnumerable<FlightStatusDto>> GetAll();
    }
}
