using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace FlightFinder.DataLayer
{
    using DataInterfaces;
    using Types;

    public class FlightStatusesRepository : IFlightStatusesRepository
    {
        private static string _connectionString;

        public FlightStatusesRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
        }

        async Task<IEnumerable<FlightStatusDto>> IFlightStatusesRepository.GetAll()
        {
            using (var dbContext = new FlightStatusesDbContext(_connectionString))
            {
                var result = from obj in dbContext.FlightStatuses
                             select new FlightStatusDto
                             {
                                 Id = obj.idflightstatus,
                                 Name = obj.name
                             };
                return await Task.Run(() => result.ToList());
            }
        }
    }
}
