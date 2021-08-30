using EazyParkingWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.ViewModels
{
    public class ParkingFormViewModel
    {
        public IEnumerable<Suburb> Suburbs { get; set; }

        public Parking Parking { get; set; }

        public String Title
        {
            get
            {
                if (Parking == null || Parking.Id == 0)
                {
                    return "New Parking";
                }
                else
                {
                    return "Edit Parking";
                }
            }
        }
    }
}