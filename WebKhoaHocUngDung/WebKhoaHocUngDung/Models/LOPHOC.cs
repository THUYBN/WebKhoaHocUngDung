namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPHOC")]
    public partial class LOPHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPHOC()
        {
            BUOIHOCs = new HashSet<BUOIHOC>();
            CT_CONGNO = new HashSet<CT_CONGNO>();
            CT_LOPHOC = new HashSet<CT_LOPHOC>();
            DANHGIACUOITHANGs = new HashSet<DANHGIACUOITHANG>();
            THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
        }

        [Key]
        public int MaLop { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100)]
        public string TenLop { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? SiSo { get; set; }

        public int? MaGV { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgayBD { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgayKT { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgayMoLop { get; set; }

        public bool TrangThai { get; set; }

        public int? MaHP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUOIHOC> BUOIHOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_CONGNO> CT_CONGNO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LOPHOC> CT_LOPHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIACUOITHANG> DANHGIACUOITHANGs { get; set; }

        public virtual HOCPHI HOCPHI { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
    }
}
