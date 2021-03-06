using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EazyParkingWithAuth.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter your full name")]
        [StringLength(255)]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name="Membership Type")]
        public int MembershipTypeId { get; set; }

        [Over18YearsOldIfCustomer]
        public DateTime? Birthday { get; set; }
    }
}