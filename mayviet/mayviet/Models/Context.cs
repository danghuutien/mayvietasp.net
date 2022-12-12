using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mayviet.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        : base("name=LienMinhHTX")
        { }

        public virtual DbSet<Danhmucsanpham> Danhmucsanphams { get; set; }
        public virtual DbSet<DM_LinhVucHoatDong> DM_LinhVucHoatDongs { get; set; }
        public virtual DbSet<DM_LoaiHinhKinhTe> DM_LoaiHinhKinhTes { get; set; }
        public virtual DbSet<DM_MoHinhHoatDong> DM_MoHinhHoatDongs { get; set; }
        public virtual DbSet<DM_NganhNghe> DM_NganhNghes { get; set; }
        public virtual DbSet<DM_NhomSanPham> DM_NhomSanPhams { get; set; }
        public virtual DbSet<DM_SanPham> DM_SanPhams { get; set; }
        public virtual DbSet<DM_TrinhDo> DM_TrinhDos { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }

        public virtual DbSet<HoatDongDauTu> HoatDongDauTus { get; set; }
        public virtual DbSet<KetQuaKinhDoanh> KetQuaKinhDoanhs { get; set; }
        public virtual DbSet<LaoDongHTX> LaoDongHTXs { get; set; }
        public virtual DbSet<KyBienDong> KyBienDongs { get; set; }
        public virtual DbSet<LaoDongLMHTX> LaoDongLMHTXs { get; set; }
        
        public virtual DbSet<TaiSan> TaiSans { get; set; }
        public virtual DbSet<ThanhVienHTX> ThanhVienHTXs { get; set; }
        public virtual DbSet<ThanhVienLMHTX> ThanhVienLMHTXs { get; set; }

        public virtual DbSet<TrinhDoCanBoChuChot> TrinhDoCanBoChuChots { get; set; }
        public virtual DbSet<VonDieuLe> VonDieuLes { get; set; }
    }
}