namespace Dental360TestDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string PatientPhone { get; set; }

        public int ServiceId { get; set; }

        public int StaffId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AppointmentDate { get; set; }

        public DateTime AppointmentStartTime { get; set; }

        public DateTime AppointmentEndTime { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Service Service { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
