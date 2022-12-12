using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("LaoDongHTXs")]
    public class LaoDongHTX
    {
        [Key]
        public int Id { get; set; }
        public double? TongSo { get; set; }
        public double? LaThanhVien { get; set; }
        public double? KhongThanhVien { get; set; }
        public double? ThuocHTXCungUngDichVu { get; set; }
        public double? ThuocHTXTaoViecLamThanhVien { get; set; }
        public double? LaoDongNam { get; set; }
        public double? LaoDongNu { get; set; }
        public double? CaoDangDaiHoc { get; set; }
        public double? TrungCap { get; set; }
        public double? SoCap { get; set; }
        public double? ChuaQuaDaoTao { get; set; }
        public double? ThamGiaBHXH { get; set; }
        public double? DonViId { get; set; } // khóa ngoại
        public double? KyBienDongId { get; set; } // khóa ngoại


        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }
    }
}