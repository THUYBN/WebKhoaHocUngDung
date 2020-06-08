namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCPHI")]
    public partial class HOCPHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCPHI()
        {
            LOPHOCs = new HashSet<LOPHOC>();
        }

        [Key]
        public int MaHP { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgayApDung { get; set; }

        public int? MaMon { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public decimal? DonGia { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public double? SoBuoi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? SiSo { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPHOC> LOPHOCs { get; set; }
    }
}
