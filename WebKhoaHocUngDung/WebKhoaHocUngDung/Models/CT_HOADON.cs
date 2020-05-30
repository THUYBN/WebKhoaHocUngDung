namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBuoi { get; set; }

        public decimal? Luong { get; set; }

        public virtual BUOIHOC BUOIHOC { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
