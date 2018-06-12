using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightFinder.DataLayer
{
    [Table("flights")]
    public class FlightsDao
    {
        [Key]
        public int idflight { get; set; }
        public Decimal price { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public int? idflightstatus { get; set; }
        public string airline { get; set; }

        [ForeignKey("idflightstatus")]
        public virtual FlightStatusesDao FlightStatus { get; set; }
    }
}
