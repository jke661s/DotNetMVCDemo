using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.Models
{
    public class Parking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Suburb Suburb { get; set; }
        public int SuburbId { get; set; }
        public int AvailableAmount { get; set; }
    }
}