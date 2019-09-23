using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MIS4200_golec.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MIS4200_golec.DAL
{
    public class Context : DbContext //inherits from DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employeer> Employeers { get; set; }
        public DbSet<Departments> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}