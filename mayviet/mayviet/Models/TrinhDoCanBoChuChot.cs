using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("TrinhDoCanBoChuChots")]
    public class TrinhDoCanBoChuChot
    {
        [Key]
        public int Id { get; set; }
        public string ChucDanh { get; set; }
        public int? TrinhDo { get; set; }
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