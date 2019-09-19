using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class pet
    {
        public int petId { get; set; }
        public string animalType { get; set; }
        public string petName { get; set; }
        public string ownerFirstName { get; set; }
        public string ownerLastName { get; set; }
        public int age { get; set; }

    }
}