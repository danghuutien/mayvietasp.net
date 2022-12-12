using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("TaiSans")]
    public class TaiSan
    {
        [Key]
        public int Id { get; set; }
        public double? TongCongTaiSan { get; set; }
        public double? TaiSanDatKhongChia { get; set; }
        public double? TaiSanHoTroKhongChia { get; set; }
        public double? TaiSanTrichLaiKhongChia { get; set; }
        public double? TaiSanDieuLeQuyDinhKhongChua { get; set; }
        public double? VonNoPhaiTra { get; set; }
        public double? VonChuSoHuu { get; set; }
        public double? DonViId { get; set; } // khoas ngoaij
        public double? KyBienDongId { get; set; } // khoas ngoaij

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }
    }
}