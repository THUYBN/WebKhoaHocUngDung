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
            LOPHOCs = new HashSet<LOPHOC>();
        }

        [Key]
        public int MaGV { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string HoTenGV { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [RegularExpression(@"^([\(]{1}[0-9]{3}[\)]{1}[\.| |\-]{0,1}|^[0-9]{3}[\.|\-| ]?)?[0-9]{3}(\.|\-| )?[0-9]{4}$", ErrorMessage = "Số điện thoại phải đủ 10 chữ số")]
        [StringLength(10, ErrorMessage = "Số điện thoại không quá 10 chữ số")]
        public string SDTGV { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(3)]
        public string Phai { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        public string ApplicationUserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUOIHOC> BUOIHOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPHOC> LOPHOCs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGOAIGIO> NGOAIGIOs { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
