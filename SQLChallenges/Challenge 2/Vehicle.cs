using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_2
{
   public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string Vin { get; set; }
        public decimal Miles { get; set; }
    }
}
