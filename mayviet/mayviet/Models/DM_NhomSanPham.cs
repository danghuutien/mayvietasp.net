using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("DM_NhomSanPhams")]
    public class DM_NhomSanPham
    {
        [Key]
        public int Id { get; set; }
        public string TenNhomSanPham { get; set; }
        public int? Status { get; set; }

        public int? CreateById { get; set; }

        public DateTime? CreateByDate { get; set; }

        public int? LastUpdateById { get; set; }

        public DateTime? LastUpdateDate { get; set; }

        public int? Order { get; set; }

    }
}