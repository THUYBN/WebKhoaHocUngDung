namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAILIEU")]
    public partial class TAILIEU
    {
        [Key]
        public int MaTL { get; set; }

        [StringLength(50)]
        public string TenTL { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        public int? MaMon { get; set; }

        public int? Khoi { get; set; }

        public virtual MONHOC MONHOC { get; set; }
    }
}
