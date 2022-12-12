using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("DonVis")]
    public class DonVi
    {
        [Key]
        public int Id { get; set; }
        public string MaSo { get; set; }
        public DateTime NamThanhLap { get; set; }
        public string DiaChi { get; set; }
        public string DaiDienPhapLuat { get; set; }
        public double? DienThoai { get; set; }
        public int? NganhNghe { get; set; }
        public int? LoaiHinh { get; set; }
        public int MoHinh { get; set; }
        public int? LinhVuc { get; set; }
        public int SanPhamTieuBieu { get; set; }

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }
    }
}