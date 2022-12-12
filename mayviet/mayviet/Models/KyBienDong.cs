using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("KyBienDongs")]
    public class KyBienDong
    {
        [Key]
        public int Id { get; set; }
        public string TenKyBienDong { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgàyKetThuc { get; set; }

        public int? Status { get; set; }
        public int? CreateById { get; set; }
        public DateTime? CreateByDate { get; set; }
        public int? LastUpdateById { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}