using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightFinder.DataLayer
{
    [Table("flightstatuses")]
    public class FlightStatusesDao
    {
        [Key]
        public int idflightstatus { get; set; }
        public string name { get; set; }
    }
}
