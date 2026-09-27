namespace Badminton;
public class PhieuDatSan 
{
    private KhachHang khachHang;
    private SanCauLong san;
    private double soGioThue;

    public PhieuDatSan(KhachHang khachHang, SanCauLong san, double soGio) 
    {
        this.khachHang = khachHang;
        this.san = san;
        this.soGioThue = soGio;
    }
    
    public KhachHang GetKhachHang() => khachHang;
    public double TinhTienSan() => san.GetGiaThu() * soGioThue;
}