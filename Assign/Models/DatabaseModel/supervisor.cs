namespace Assign.Models.DatabaseModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("supervisor")]
    public partial class supervisor
    {
        [Key]
        [StringLength(22)]
        public string supervisor_id { get; set; }

        [StringLength(20)]
        public string supervisor_name { get; set; }
    }
}
