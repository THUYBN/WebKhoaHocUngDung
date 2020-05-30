namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAOVIEN")]
    public partial class GIAOVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOVIEN()
        {
            BUOIHOCs = new HashSet<BUOIHOC>();
            HOADONs = new HashSet<HOADON>();
            NGOAIGIOs = new HashSet<NGOAIGIO>();
        }

        [Key]
        public int MaGV { get; set; }

        [StringLength(50)]
        public string HoTenGV { get; set; }

        [StringLength(10)]
        public string SDTGV { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(3)]
        public string Phai { get; set; }

        public DateTime? NgaySinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUOIHOC> BUOIHOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGOAIGIO> NGOAIGIOs { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
