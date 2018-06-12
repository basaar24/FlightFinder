using System.Data.Entity;


namespace FlightFinder.DataLayer
{
    public class FlightStatusesDbContext : DbContext
    {
        public FlightStatusesDbContext(string connectionString)
            : base(connectionString)
        { }

        public virtual DbSet<FlightStatusesDao> FlightStatuses { get; set; }
    }
}
