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
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50)]



        public string description { get; set; }

        [Display(Name = "Visit Date")]
        [Required(ErrorMessage = "Visit Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]


        public DateTime visitDate { get; set; }
        [Display(Name = "Vet Name")]

        public int vetId { get; set; }
        public virtual vet vet { get; set; }
        [Display(Name = "Animal Type")]

        public int petId { get; set; }
        public virtual pet pet { get; set; }
    }
}