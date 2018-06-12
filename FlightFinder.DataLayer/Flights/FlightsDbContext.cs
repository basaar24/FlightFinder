using System.Data.Entity;

namespace FlightFinder.DataLayer
{
    public class FlightsDbContext : DbContext
    {
        public FlightsDbContext(string connectionString)
            : base(connectionString)
        { }


        public virtual DbSet<FlightsDao> Flights { get; set; }
        public virtual DbSet<FlightStatusesDao> FlightStatuses { get; set; }
    }
}
