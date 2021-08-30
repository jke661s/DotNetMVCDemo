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
        public String Title {
            get
            {
                if (Customer == null || Customer.Id == 0)
                {
                    return "New Customer";
                } else 
                {
                    return "Edit Customer";
                }
            }
        }
    }
}