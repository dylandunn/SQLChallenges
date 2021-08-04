using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Challenge_3
{
   public class House
    {
        public Guid HouseId { get; set; }
        public decimal NumberOfBedrooms { get; set; }
        public decimal NumberOfBaths { get; set; }
        public decimal EsitmatedValue { get; set; }
    }
}
