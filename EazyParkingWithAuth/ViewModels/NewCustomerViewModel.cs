using System;
using System.Collections.Generic;
using EazyParkingWithAuth.Models;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

    }
}