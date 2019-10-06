using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class pet
    {
        public int petId { get; set; }

        [Display (Name ="Animal Type")]
        [Required (ErrorMessage = "Animal type is required")]
        [StringLength(20)]
        public string animalType { get; set; }
        
        [Display (Name ="Pet Name")]
        [Required(ErrorMessage = "Pet Name is required")]
        [StringLength(20)]


        public string petName { get; set; }

        [Display(Name = "Owner First Name")]
        [Required(ErrorMessage = "Owner First Name is required")]
        [StringLength(20)]


        public string ownerFirstName { get; set; }
        [Display(Name = "Owner Last Name")]
        [Required(ErrorMessage = "Owner Last Name is required")]
        [StringLength(20)]



        public string ownerLastName { get; set; }

        [Display(Name = "Pet Age")]
        [Required(ErrorMessage = "Pet Age is required")]

        public int age { get; set; }

    }
}