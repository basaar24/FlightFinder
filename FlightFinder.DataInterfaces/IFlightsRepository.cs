using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.DataInterfaces
{
    using Types;

    public interface IFlightsRepository
    {
        Task<IEnumerable<FlightDto>> GetAll();
    }
}
