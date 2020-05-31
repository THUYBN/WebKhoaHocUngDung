namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHGIACUOITHANG")]
    public partial class DANHGIACUOITHANG
    {
        [Key]
        public int MaDG { get; set; }

        [StringLength(500)]
        public string NhanXet { get; set; }

        [StringLength(50)]
        public string ChuyenCan { get; set; }

        public DateTime? NgayLap { get; set; }

        public int? MaLop { get; set; }

        public int? MaHS { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
