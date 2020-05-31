namespace WebKhoaHocUngDung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THOIKHOABIEU")]
    public partial class THOIKHOABIEU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Thu { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ThoiGianBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianKT { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
