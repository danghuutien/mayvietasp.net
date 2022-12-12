using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("VonDieuLes")]
    public class VonDieuLe
    {
        [Key]
        public int Id { get; set; }
        public int? TongVonDieuLe { get; set; }
        public int? TongThanhVienGop { get; set; }
        public int? ThapNhat { get; set; }
        public int? CaoNhat { get; set; }
        public int? DonViId { get; set; }// khóa ngoại 
        public int? KyBienDongId { get; set; } // khóa ngoại từ

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? Order { get; set; }

    }
}