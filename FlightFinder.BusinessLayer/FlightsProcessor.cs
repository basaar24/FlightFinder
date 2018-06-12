using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightFinder.BusinessLayer
{
    using BusinessInterfaces;
    using DataInterfaces;
    using Types;

    public class FlightsProcessor : IFlightsProcessor
    {
        private readonly IFlightsRepository _flightRepository;

        public FlightsProcessor(IFlightsRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task<IEnumerable<FlightDto>> GetAll()
        {
            try
            {
                return await _flightRepository.GetAll();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
