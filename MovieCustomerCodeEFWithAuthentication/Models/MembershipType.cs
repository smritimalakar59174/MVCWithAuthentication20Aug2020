using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCustomerCodeEFWithAuthentication.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignupFree { get; set; }
        public byte DurationMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}