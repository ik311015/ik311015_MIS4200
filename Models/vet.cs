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
        [Required(ErrorMessage = "Vet First Name is required")]
        [StringLength(20)]

        public string firstName { get; set; }

        [Display(Name = "Vet Last Name")]
        [Required(ErrorMessage = "Vet Last Name is required")]
        [StringLength(20)]


        public string lastName { get; set; }

        [Display(Name = "Vet Email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]

        public string email { get; set; }

        [Display(Name = "Vet Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]

        public string phone { get; set; }
        public ICollection<visit> visit { get; set; }
    }
}