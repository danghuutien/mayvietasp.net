using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    [Table("Danhmucsanphams")]
    public class Danhmucsanpham
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Create_at { get; set; }
        public DateTime? Update_at { get; set; }
    }
}