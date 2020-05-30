namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class HOCSINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCSINH()
        {
            CONGNOes = new HashSet<CONGNO>();
            CT_LOPHOC = new HashSet<CT_LOPHOC>();
            DANHGIACUOITHANGs = new HashSet<DANHGIACUOITHANG>();
        }

        [Key]
        public int MaHS { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        public int? Khoi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string SDTPH { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public DateTime? NgayVaoHoc { get; set; }

        public bool? TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGNO> CONGNOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LOPHOC> CT_LOPHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIACUOITHANG> DANHGIACUOITHANGs { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
