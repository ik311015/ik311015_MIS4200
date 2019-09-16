using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ik311015_MIS4200.Models;

namespace ik311015_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<customer> Customer { get; set; }
        public DbSet<order> Order { get; set; }
        public DbSet<customerOrder> customerOrder { get; set; }
        public DbSet<lineItem> lineItem { get; set; }
        public DbSet<product> product { get; set; }


    }

    
}