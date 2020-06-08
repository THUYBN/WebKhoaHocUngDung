namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            HOCPHIs = new HashSet<HOCPHI>();
            TAILIEUx = new HashSet<TAILIEU>();
        }

        [Key]
        public int MaMonHoc { get; set; }

        public int MaKhoi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string TenMonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCPHI> HOCPHIs { get; set; }

        public virtual KHOI KHOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAILIEU> TAILIEUx { get; set; }
    }
}
