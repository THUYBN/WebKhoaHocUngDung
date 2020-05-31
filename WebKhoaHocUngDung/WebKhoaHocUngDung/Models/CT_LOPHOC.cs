namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_LOPHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_LOPHOC()
        {
            CT_BUOIHOC = new HashSet<CT_BUOIHOC>();
        }

        [Key]
        public int MaCT { get; set; }

        public int? MaLop { get; set; }

        public int? MaHS { get; set; }

        public DateTime? NgayVaoHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BUOIHOC> CT_BUOIHOC { get; set; }

        public virtual HOCSINH HOCSINH { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
