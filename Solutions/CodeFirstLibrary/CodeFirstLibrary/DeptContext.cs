using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstLibrary
{
    public class DeptContext:DbContext
    {
        public DbSet<Department> Depts { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(u => u.DeptName).HasColumnName("display_name");
        }
    }
}
