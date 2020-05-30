namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
            CT_HOADON_NGOAIGIO = new HashSet<CT_HOADON_NGOAIGIO>();
        }

        [Key]
        public int MaHD { get; set; }

        [StringLength(50)]
        public string TenHD { get; set; }

        public int? MaGV { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public decimal? TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON_NGOAIGIO> CT_HOADON_NGOAIGIO { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
