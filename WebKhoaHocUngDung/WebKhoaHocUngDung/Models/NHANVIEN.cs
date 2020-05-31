namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string HoTenNV { get; set; }

        [StringLength(10)]
        public string SDTNV { get; set; }

        [StringLength(50)]
        public string DiacChi { get; set; }

        [StringLength(3)]
        public string Phai { get; set; }

        public DateTime? NgaySinh { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
