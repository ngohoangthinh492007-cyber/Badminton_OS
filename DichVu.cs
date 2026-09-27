namespace Badminton
{
    public abstract class DichVu
    {
        public string MaDV { get; }
        public string TenDV { get; }
        public double DonGia { get; }
        public int SoLuongTon { get; set; }

        public DichVu(string ma, string ten, double gia, int tonKho = 999) 
        { 
            MaDV = ma; 
            TenDV = ten; 
            DonGia = gia; 
            SoLuongTon = tonKho; 
        }

        public abstract string LoaiSanPham();
    }
    public class NuocUong : DichVu 
    { 
        public NuocUong(string ma, string ten, double gia, int ton = 999) 
            : base(ma, ten, gia, ton) { } 

        public override string LoaiSanPham() => "Nước uống"; 
    }
    public class DoAn : DichVu 
    { 
        public DoAn(string ma, string ten, double gia, int ton = 999) 
            : base(ma, ten, gia, ton) { } 

        public override string LoaiSanPham() => "Đồ ăn"; 
    }
    public class ThueDungCu : DichVu 
    { 
        public string TinhTrang { get; set; }

        public ThueDungCu(string ma, string ten, double gia, int ton = 999, string tinhTrang = "Mới") 
            : base(ma, ten, gia, ton) 
        { 
            TinhTrang = tinhTrang;
        } 

        public override string LoaiSanPham() => "Thuê dụng cụ"; 
    }
    public class PhuKien : DichVu 
    { 
        public PhuKien(string ma, string ten, double gia, int ton = 999) 
            : base(ma, ten, gia, ton) { } 

        public override string LoaiSanPham() => "Phụ kiện"; 
    }
}
