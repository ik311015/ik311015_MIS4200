using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class visit
    {
        public int visitId { get; set; }
        [Display(Name = "Description")]

        public string description { get; set; }
        [Display(Name = "Visit Date")]

        public DateTime visitDate { get; set; }
        public int vetId { get; set; }
        public virtual vet vet { get; set; }
        public int petId { get; set; }
        public virtual pet pet { get; set; }
    }
}