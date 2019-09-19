using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ik311015_MIS4200.Models;

namespace ik311015_MIS4200.DAL
{
    public class petContext : DbContext
    {
        public petContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
            ik311015_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }
        public DbSet<vet> Vet { get; set; }
        public DbSet<visit> Visit { get; set; }
        public DbSet<pet> Pet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }


}