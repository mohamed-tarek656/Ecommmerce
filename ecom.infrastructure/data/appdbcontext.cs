using ecom.core.entities.product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ecom.infrastructure.data
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions<appdbcontext> options) : base(options)
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<photo> photos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //to told him what i do in config
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
