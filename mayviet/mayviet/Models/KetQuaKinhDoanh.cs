using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("KetQuaKinhDoanhs")]
    public class KetQuaKinhDoanh
    {
        [Key]
        public int Id { get; set; }
        public double? TongDoanhThu { get; set; }
        public double? DoanhThuThanhVien { get; set; }
        public double? TyLeKetQua { get; set; }
        public double? LoiNhuanTruocThue { get; set; }
        public double? LoiNhuanSauThue { get; set; }
        public double? LoiNhuanTrichQuyDTPT { get; set; }
        public double? LoiNhuanTrichQuyDPTC { get; set; }
        public double? LoiNhuanTrichQuyKhac { get; set; }
        public double LoiNhuanChiaThanhVienTheoSuDungDichVu { get; set; }
        public double? LoiNhuanChiaThanhVienTheoGopVon { get; set; }
        public double? LoiNhuanChiaThanhVienTheoKhac { get; set; }
        public double? TongQuyLuong { get; set; }
        public double? TongKhachHangVayvon { get; set; }
        public double? TongDuNoChoVay { get; set; }
        public double? DonViId { get; set; } // khoa ngoai
        public double? KyBienDongId { get; set; } // khoa ngoai


        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }

    }
}