namespace Assign.Models.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("staff")]
    public partial class staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public staff()
        {
            staff1 = new HashSet<staff>();
        }

        [Key]
        [StringLength(20)]
        public string staff_id { get; set; }

        [StringLength(50)]
        public string staff_name { get; set; }

        [StringLength(50)]
        public string staff_email { get; set; }

        [StringLength(20)]
        public string supervisor_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<staff> staff1 { get; set; }

        public virtual staff staff2 { get; set; }
    }
}
