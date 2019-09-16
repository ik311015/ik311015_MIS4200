using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class customerOrder
    {
        public int customerOrderID { get; set; }
        public int customerID { get; set; }
        public virtual customer customer { get; set; }
        public ICollection<lineItem> lineItem { get; set; }
        public DateTime orderDate { get; set; }
    }
}