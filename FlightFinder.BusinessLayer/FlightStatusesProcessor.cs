
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.BusinessLayer
{
    using BusinessInterfaces;
    using DataInterfaces;
    using Types;

    public class FlightStatusesProcessor : IFlightsStatusesProcessor
    {
        private readonly IFlightStatusesRepository _flightStatusesRepository;

        public FlightStatusesProcessor(IFlightStatusesRepository flightStatusesRepository)
        {
            _flightStatusesRepository = flightStatusesRepository;
        }

        async Task<IEnumerable<FlightStatusDto>> IFlightsStatusesProcessor.GetAll()
        {
            try
            {
                return await _flightStatusesRepository.GetAll();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
