namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_BUOIHOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBuoi { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCT { get; set; }

        public bool? DiemDanhHS { get; set; }

        [StringLength(500)]
        public string NhanXetGV { get; set; }

        [StringLength(500)]
        public string BTVN { get; set; }

        [StringLength(100)]
        public string LiDoVang { get; set; }

        public double? Diem { get; set; }

        public virtual BUOIHOC BUOIHOC { get; set; }

        public virtual CT_LOPHOC CT_LOPHOC { get; set; }
    }
}
