using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class vet
    {
        public int vetId { get; set; }

        [Display(Name = "Vet First Name")]
        public string firstName { get; set; }

        [Display(Name = "Vet Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Vet Email")]
        public string email { get; set; }

        [Display(Name = "Vet Phone Number")]
        public string phone { get; set; }
        public ICollection<visit> visit { get; set; }
    }
}