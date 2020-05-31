namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGOAIGIO")]
    public partial class NGOAIGIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGOAIGIO()
        {
            CT_HOADON_NGOAIGIO = new HashSet<CT_HOADON_NGOAIGIO>();
        }

        [Key]
        public int MaNgoaiGio { get; set; }

        public int? MaLoaiLuong { get; set; }

        public int? MaGV { get; set; }

        public DateTime? NgayLam { get; set; }

        public int? SoGioLam { get; set; }

        public virtual BANGLUONG BANGLUONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON_NGOAIGIO> CT_HOADON_NGOAIGIO { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
