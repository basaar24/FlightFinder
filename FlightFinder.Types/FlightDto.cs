using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FlightFinder.Types
{
    public class FlightDto : TypeBase
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Origin")]
        [MaxLength(150)]
        public string Origin { get; set; }

        [Required]
        [DisplayName("Destination")]
        [MaxLength(150)]
        public string Destination { get; set; }

        [Required]
        [DisplayName("Price")]
        [DataType(DataType.Currency)]
        public Decimal Price { get; set; }

        [Required]
        [DisplayName("Departure Time")]
        [DataType(DataType.DateTime)]
        public DateTime Departure { get; set; }

        [Required]
        [DisplayName("Arrival Time")]
        [DataType(DataType.DateTime)]
        public DateTime Arrival { get; set; }

        [Required]
        [DisplayName("Flight Status")]
        public FlightStatusDto FlightStatus { get; set; }
        public IEnumerable<FlightStatusDto> FlightStatuses { get; set; }

        [Required]
        [DisplayName("Airline")]
        [MaxLength(150)]
        public string Airline{ get; set; }
    }
}
