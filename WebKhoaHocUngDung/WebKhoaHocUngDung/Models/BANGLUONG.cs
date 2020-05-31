namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGLUONG")]
    public partial class BANGLUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGLUONG()
        {
            BUOIHOCs = new HashSet<BUOIHOC>();
            NGOAIGIOs = new HashSet<NGOAIGIO>();
        }

        [Key]
        public int MaLoaiLuong { get; set; }

        [StringLength(30)]
        public string TenLoai { get; set; }

        public double? SoLuongMin { get; set; }

        public double? SoLuongMax { get; set; }

        public decimal? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUOIHOC> BUOIHOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGOAIGIO> NGOAIGIOs { get; set; }
    }
}
