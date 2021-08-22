using EazyParkingWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.ViewModels
{
    public class RandomParkingViewModel
    {
        public Parking Parking { get; set; }
        public List<Customer> Customers{ get; set; }
    }
}   