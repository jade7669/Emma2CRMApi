using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Emma2CRMApi.Models
{
    public class E2CDbContext : DbContext
    {
        public E2CDbContext() : base("name=DefaultConnection") { }
        public DbSet<E2CClientBaseInfo> Subscriptions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove();
        }
    }
}