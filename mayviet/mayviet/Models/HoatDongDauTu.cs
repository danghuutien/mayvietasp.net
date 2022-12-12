using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("HoatDongDauTus")]
    public class HoatDongDauTu
    {
        [Key]
        public int Id { get; set; }
        public int? TongVonGop { get; set; }
        public int? TongCoPhan { get; set; }
        public string TongVonDieuLeDoanhNghiep { get; set; }
        public int? Status { get; set; }

        public int? CreateById { get; set; }

        public DateTime? CreateByDate { get; set; }

        public int? LastUpdateById { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public int? Order { get; set; }

    }
}