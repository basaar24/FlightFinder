using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.DataInterfaces
{
    using Types;

    public interface IFlightStatusesRepository
    {
        Task<IEnumerable<FlightStatusDto>> GetAll();
    }
}
