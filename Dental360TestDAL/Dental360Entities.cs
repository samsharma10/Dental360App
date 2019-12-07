namespace Dental360TestDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Dental360Entities : DbContext
    {
        public Dental360Entities()
            : base("name=Dental360Connection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffEmail)
                .IsUnicode(false);
        }
    }
}
