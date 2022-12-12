namespace mayviet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhh : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Danhmucsanphams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        THumbnail = c.String(),
                        Content = c.String(),
                        Create_at = c.DateTime(),
                        Update_at = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_LinhVucHoatDongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLinhVucHoatDong = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_LoaiHinhKinhTes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenLoaiHinhKinhTe = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_MoHinhHoatDongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMoHinhHoatDong = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_NganhNghes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenNganhNghe = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_NhomSanPhams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenNhomSanPham = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_SanPhams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        NhomSanPhamId = c.Int(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DM_TrinhDos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenTrinhDo = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DonVis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaSo = c.String(),
                        NamThanhLap = c.DateTime(nullable: false),
                        DiaChi = c.String(),
                        DaiDienPhapLuat = c.String(),
                        DienThoai = c.Double(),
                        NganhNghe = c.Int(),
                        LoaiHinh = c.Int(),
                        MoHinh = c.Int(nullable: false),
                        LinhVuc = c.Int(),
                        SanPhamTieuBieu = c.Int(nullable: false),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HoatDongDauTus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongVonGop = c.Int(),
                        TongCoPhan = c.Int(),
                        TongVonDieuLeDoanhNghiep = c.String(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KetQuaKinhDoanhs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongDoanhThu = c.Double(),
                        DoanhThuThanhVien = c.Double(),
                        TyLeKetQua = c.Double(),
                        LoiNhuanTruocThue = c.Double(),
                        LoiNhuanSauThue = c.Double(),
                        LoiNhuanTrichQuyDTPT = c.Double(),
                        LoiNhuanTrichQuyDPTC = c.Double(),
                        LoiNhuanTrichQuyKhac = c.Double(),
                        LoiNhuanChiaThanhVienTheoSuDungDichVu = c.Double(nullable: false),
                        LoiNhuanChiaThanhVienTheoGopVon = c.Double(),
                        LoiNhuanChiaThanhVienTheoKhac = c.Double(),
                        TongQuyLuong = c.Double(),
                        TongKhachHangVayvon = c.Double(),
                        TongDuNoChoVay = c.Double(),
                        DonViId = c.Double(),
                        KyBienDongId = c.Double(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KyBienDongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenKyBienDong = c.String(),
                        NgayBatDau = c.DateTime(),
                        NgàyKetThuc = c.DateTime(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LaoDongHTXs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongSo = c.Double(),
                        LaThanhVien = c.Double(),
                        KhongThanhVien = c.Double(),
                        ThuocHTXCungUngDichVu = c.Double(),
                        ThuocHTXTaoViecLamThanhVien = c.Double(),
                        LaoDongNam = c.Double(),
                        LaoDongNu = c.Double(),
                        CaoDangDaiHoc = c.Double(),
                        TrungCap = c.Double(),
                        SoCap = c.Double(),
                        ChuaQuaDaoTao = c.Double(),
                        ThamGiaBHXH = c.Double(),
                        DonViId = c.Double(),
                        KyBienDongId = c.Double(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LaoDongLMHTXs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongSo = c.Double(),
                        CaoDangDaiHoc = c.Double(),
                        TrungCap = c.Double(),
                        SoCap = c.Double(),
                        ChuaQuaDaoTao = c.Double(),
                        ThamGiaBHXH = c.Double(),
                        DonViId = c.Double(),
                        KyBienDongId = c.Double(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TaiSans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongCongTaiSan = c.Double(),
                        TaiSanDatKhongChia = c.Double(),
                        TaiSanHoTroKhongChia = c.Double(),
                        TaiSanTrichLaiKhongChia = c.Double(),
                        TaiSanDieuLeQuyDinhKhongChua = c.Double(),
                        VonNoPhaiTra = c.Double(),
                        VonChuSoHuu = c.Double(),
                        DonViId = c.Double(),
                        KyBienDongId = c.Double(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ThanhVienHTXs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongSo = c.Double(),
                        ThamGiaMoi = c.Double(),
                        CaNhan = c.Double(),
                        HoGiaDinh = c.Double(),
                        PhapNhan = c.Double(),
                        SuDungDichVu = c.Double(),
                        KhongSuDungDichVu = c.Double(),
                        NongNghiep = c.Double(),
                        PhiNongNghiep = c.Double(),
                        QTDND = c.Double(),
                        GiaThanhVien = c.Double(),
                        ThamGiaDaiHoi = c.Double(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ThanhVienLMHTXs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongSo = c.Double(),
                        ThamGiaMoi = c.Int(),
                        KhongSuDungDichVu = c.Int(),
                        SuDungDichVuNHHTX = c.Int(),
                        SưDungDichVuNongNghiep = c.Int(),
                        SuDungDichVuPhiNongNghiep = c.Int(),
                        GiaThanhVien = c.Int(nullable: false),
                        DonViId = c.Int(),
                        KyBienDongId = c.Int(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TrinhDoCanBoChuChots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChucDanh = c.String(),
                        TrinhDo = c.Int(),
                        DonViId = c.Int(),
                        KyBienDongId = c.Int(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VonDieuLes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TongVonDieuLe = c.Int(),
                        TongThanhVienGop = c.Int(),
                        ThapNhat = c.Int(),
                        CaoNhat = c.Int(),
                        DonViId = c.Int(),
                        KyBienDongId = c.Int(),
                        Status = c.Int(),
                        CreateById = c.Int(),
                        CreateByDate = c.DateTime(),
                        LastUpdateById = c.Int(),
                        LastUpdateDate = c.DateTime(),
                        Order = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VonDieuLes");
            DropTable("dbo.TrinhDoCanBoChuChots");
            DropTable("dbo.ThanhVienLMHTXs");
            DropTable("dbo.ThanhVienHTXs");
            DropTable("dbo.TaiSans");
            DropTable("dbo.LaoDongLMHTXs");
            DropTable("dbo.LaoDongHTXs");
            DropTable("dbo.KyBienDongs");
            DropTable("dbo.KetQuaKinhDoanhs");
            DropTable("dbo.HoatDongDauTus");
            DropTable("dbo.DonVis");
            DropTable("dbo.DM_TrinhDos");
            DropTable("dbo.DM_SanPhams");
            DropTable("dbo.DM_NhomSanPhams");
            DropTable("dbo.DM_NganhNghes");
            DropTable("dbo.DM_MoHinhHoatDongs");
            DropTable("dbo.DM_LoaiHinhKinhTes");
            DropTable("dbo.DM_LinhVucHoatDongs");
            DropTable("dbo.Danhmucsanphams");
        }
    }
}
