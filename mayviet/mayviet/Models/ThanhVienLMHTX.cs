using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("ThanhVienLMHTXs")]
    public class ThanhVienLMHTX
    {
        [Key]
        public int Id { get; set; }
        public double? TongSo { get; set; }
        public int? ThamGiaMoi { get; set; }
        public int? KhongSuDungDichVu { get; set; }
        public int? SuDungDichVuNHHTX { get; set; }
        public int? SưDungDichVuNongNghiep { get; set; }
        public int? SuDungDichVuPhiNongNghiep { get; set; }
        public int GiaThanhVien { get; set; }
        public int? DonViId { get; set; }
        public int? KyBienDongId { get; set; }

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }
    }
}