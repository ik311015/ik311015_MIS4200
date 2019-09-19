using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class vet
    {
        public int vetId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public ICollection<visit> visit { get; set; }
    }
}