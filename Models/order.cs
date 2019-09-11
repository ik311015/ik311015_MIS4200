using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public customer customer { get; set; }
        public DateTime orderDate { get; set; }
    }
}