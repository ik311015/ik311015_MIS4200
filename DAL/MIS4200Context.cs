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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
            ik311015_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<customer> Customer { get; set; }
        public DbSet<order> Order { get; set; }
        public DbSet<customerOrder> customerOrder { get; set; }
        public DbSet<lineItem> lineItem { get; set; }
        public DbSet<product> product { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<ik311015_MIS4200.Models.vet> vets { get; set; }

        public System.Data.Entity.DbSet<ik311015_MIS4200.Models.pet> pets { get; set; }

        public System.Data.Entity.DbSet<ik311015_MIS4200.Models.visit> visits { get; set; }
    }

    
}