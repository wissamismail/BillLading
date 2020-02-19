using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;


namespace BillLading
{
    public class DBModelLadings : DbContext
    {
        public DbSet<Lading> Ladings {get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
