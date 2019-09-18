﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ik311015_MIS4200.Models
{
    public class customer
    {
        public int customerId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fullName { get
            {
                return firstName + " " + lastName;
            } }
        public ICollection<order> orders { get; set; }

    }
}