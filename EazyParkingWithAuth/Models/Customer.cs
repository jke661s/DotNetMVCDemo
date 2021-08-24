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
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        // Sometimes you don't want to load the membership type as well. So you need an FK, MembershiTypeId
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime? Birthday { get; set; }
    }
}