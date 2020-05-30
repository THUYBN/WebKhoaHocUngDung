namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGNO")]
    public partial class CONGNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGNO()
        {
            CT_CONGNO = new HashSet<CT_CONGNO>();
        }

        [Key]
        public int MaCongNo { get; set; }

        public int? MaHS { get; set; }

        [StringLength(100)]
        public string TenCongNo { get; set; }

        public decimal? TongTien { get; set; }

        public DateTime? NgayThanhToan { get; set; }

        public DateTime? NgayLapCN { get; set; }

        public bool? TrangThai { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_CONGNO> CT_CONGNO { get; set; }
    }
}
