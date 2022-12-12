using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("ThanhVienHTXs")]
    public class ThanhVienHTX
    {
        [Key]
        public int Id { get; set; }
        public double? TongSo { get; set; }
        public double? ThamGiaMoi { get; set; }
        public double? CaNhan { get; set; }
        public double? HoGiaDinh { get; set; }
        public double? PhapNhan { get; set; }
        public double? SuDungDichVu { get; set; }
        public double? KhongSuDungDichVu { get; set; }
        public double? NongNghiep { get; set; }
        public double? PhiNongNghiep { get; set; }
        public double? QTDND { get; set; }
        public double? GiaThanhVien { get; set; }
        public double? ThamGiaDaiHoi { get; set; }

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }
    }
}