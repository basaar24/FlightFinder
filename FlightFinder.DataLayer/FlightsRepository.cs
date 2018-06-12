using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace FlightFinder.DataLayer
{
    using DataInterfaces;
    using Types;

    public class FlightsRepository : IFlightsRepository
    {
        private static string _connectionString;

        public FlightsRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }

        public async Task<IEnumerable<FlightDto>> GetAll()
        {
            using (var dbContext = new FlightsDbContext(_connectionString))
            {
                var result = from obj in dbContext.Flights
                             join flightStatus in dbContext.FlightStatuses on obj.idflightstatus equals flightStatus.idflightstatus
                             select new FlightDto
                             {
                                 Id = obj.idflight,
                                 Arrival = obj.arrival,
                                 Departure = obj.departure,
                                 Destination = obj.destination,
                                 FlightStatus = new FlightStatusDto()
                                 {
                                     Id = flightStatus.idflightstatus,
                                     Name = flightStatus.name
                                 },
                                 Origin = obj.origin,
                                 Price = obj.price,
                                 Airline = obj.airline
                             };

                return await Task.Run(() => result.ToList());
            }
        }
    }
}
