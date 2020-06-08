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

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? Khoi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [RegularExpression(@"^([\(]{1}[0-9]{3}[\)]{1}[\.| |\-]{0,1}|^[0-9]{3}[\.|\-| ]?)?[0-9]{3}(\.|\-| )?[0-9]{4}$", ErrorMessage = "Số điện thoại phải đủ 10 chữ số")]
        [StringLength(10, ErrorMessage ="Số điện thoại không quá 10 chữ số")]
        public string SDT { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [RegularExpression(@"^([\(]{1}[0-9]{3}[\)]{1}[\.| |\-]{0,1}|^[0-9]{3}[\.|\-| ]?)?[0-9]{3}(\.|\-| )?[0-9]{4}$", ErrorMessage = "Số điện thoại phải đủ 10 chữ số")]
        [StringLength(10, ErrorMessage = "Số điện thoại không quá 10 chữ số")]
        public string SDTPH { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string DiaChi { get; set; }

        public DateTime? NgayVaoHoc { get; set; }

        public bool? TinhTrang { get; set; }
        public string ApplicationUserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGNO> CONGNOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_LOPHOC> CT_LOPHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIACUOITHANG> DANHGIACUOITHANGs { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
