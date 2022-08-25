using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Assign.Models.DatabaseModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=hoteldb")
        {
        }

        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<supervisor> supervisors { get; set; }
     
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<staff>()
                .Property(e => e.staff_id)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.staff_name)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.staff_email)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .Property(e => e.supervisor_id)
                .IsUnicode(false);

            modelBuilder.Entity<staff>()
                .HasMany(e => e.staff1)
                .WithOptional(e => e.staff2)
                .HasForeignKey(e => e.supervisor_id);

            modelBuilder.Entity<supervisor>()
                .Property(e => e.supervisor_id)
                .IsUnicode(false);

            modelBuilder.Entity<supervisor>()
                .Property(e => e.supervisor_name)
                .IsUnicode(false);
        }
    }
}
