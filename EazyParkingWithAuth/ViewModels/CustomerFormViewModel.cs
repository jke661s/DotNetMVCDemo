using System;
using System.Collections.Generic;
using EazyParkingWithAuth.Models;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}