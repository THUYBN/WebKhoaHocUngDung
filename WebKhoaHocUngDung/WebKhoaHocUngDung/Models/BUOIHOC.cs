namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BUOIHOC")]
    public partial class BUOIHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BUOIHOC()
        {
            CT_BUOIHOC = new HashSet<CT_BUOIHOC>();
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        public int MaBuoi { get; set; }

        public int? STTBuoi { get; set; }

        public DateTime? ThoiGian { get; set; }

        public bool? TinhTrang { get; set; }

        public int? MaGV { get; set; }

        public int? MaLoaiLuong { get; set; }

        public int? MaLop { get; set; }

        public virtual BANGLUONG BANGLUONG { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BUOIHOC> CT_BUOIHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }
    }
}
