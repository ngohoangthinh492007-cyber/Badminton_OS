using Badminton;
namespace Badminton;
public class Program
{
    public static void Main(string[] args)
    {
        // 1. Cấu hình hệ thống Event
        EventDispatcher.ĐăngKý(new TichDiemListener());

        // 2. Chuẩn bị dữ liệu ban đầu
        SanCauLong sanVIP = new SanCauLong("SAN_01", 100000); // 100k/giờ
        DichVu boHuc = new DichVuHangHoa("DV01", "Bò húc", 20000, 50);
        DichVu thueVot = new DichVuChoThue("DV02", "Thuê vợt Yonex", 50000, "Tốt");

        // 3. Khách quen đến chơi (Đang có 150 điểm sẵn trong Database)
        KhachHang khachQuen = new KhachThanhVien("KH01", "Trần Thị B", "090123", 150);

        PhieuDatSan phieu = new PhieuDatSan(khachQuen, sanVIP, 2); // Thuê 2 giờ

        // 4. Lập hóa đơn và tính tiền
        HoaDon bill = new HoaDon(phieu);
        bill.ThemDichVu(boHuc);
        bill.ThemDichVu(thueVot);

        // Khách chọn chuyển khoản
        bill.ChonPhuongThucThanhToan(new ThanhToanChuyenKhoan());

        // Xử lý toàn bộ luồng nghiệp vụ
        bill.XuLyThanhToan();
    }
}