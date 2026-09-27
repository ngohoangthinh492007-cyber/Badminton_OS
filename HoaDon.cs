namespace  Badminton;
public class HoaDon
{
    private PhieuDatSan phieu;
    private List<DichVu> danhSachDichVu = new List<DichVu>();
    private IThanhToan? phuongThucThanhToan;
    public HoaDon(PhieuDatSan phieu)
    {
        this.phieu=phieu;
    }
    public void ThemDichVu(DichVu dv)
    {
        danhSachDichVu.Add(dv);
        Console.WriteLine($"+ Thêm dịch vụ: {dv.GetTenDv()}");    
    }
    public void ChonPhuongThucThanhToan(IThanhToan hinhthuc)
    {
        this.phuongThucThanhToan=hinhthuc;
    }
    public void XuLyThanhToan()
    {
        Console.WriteLine("\n--- TỔNG HỢP HÓA ĐƠN ---");
        //1 Tinh tong chi phi (san+dv)
        double tongTienGoc=phieu.TinhTienSan();
        foreach (var dv in danhSachDichVu)
        {
            tongTienGoc+=dv.GetDonGia();
        }
        Console.WriteLine($"Tổng tiền gốc: {tongTienGoc}đ");
        //2 Yeu cau khach hang thanh toan (xu ly da hinh giam gia)
        KhachHang kh=phieu.GetKhachHang();
        double tienThucThu=kh.YeuCauThanhToan(tongTienGoc);
        //3 Tien hanh thanh toan
        phuongThucThanhToan.ThucHienThanhToan(tienThucThu);
        EventDispatcher.PhátSựKiện(new TaoBillThanhCongEvent(kh, tienThucThu));
        
        Console.WriteLine("------------------------\n");
    }
}