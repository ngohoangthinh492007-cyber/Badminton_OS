namespace Badminton;
public class KhachThanhVien : KhachHang 
{
    private int capDo;
    private double tiLeGiamGia;

    public KhachThanhVien(string maKhachHang, string hoTen, string soDienThoai, int diemTichLuy) 
        : base(maKhachHang, hoTen, soDienThoai, diemTichLuy) 
    {
        CapNhatCapDo(); // Tính toán cấp độ ngay khi tạo đối tượng (hoặc load từ DB)
    }

    // Ghi đè hàm TichDiem để tự động xét thăng cấp mỗi khi được cộng điểm
    public override void TichDiem(int diem)
    {
        base.TichDiem(diem); // Chạy logic cộng điểm của lớp cha
        CapNhatCapDo();      // Kiểm tra xem có đủ điểm lên cấp không
    }

    // Tính Đóng gói (Encapsulation): Logic tính cấp độ giấu kín, bên ngoài không thể tự sửa
    private void CapNhatCapDo()
    {
        // Công thức: 100 điểm = 1 cấp
        int capDoHienTai = (this.diemTichLuy / 100) + 1;
        
        // RÀNG BUỘC 1: Cấp độ tối đa là 5
        this.capDo = Math.Min(capDoHienTai, 5); 

        // RÀNG BUỘC 2: Giảm giá tối đa 20% (Mỗi cấp 4% -> Cấp 5 = 20%)
        this.tiLeGiamGia = Math.Min(this.capDo * 0.04, 0.20); 
    }

    public override double YeuCauThanhToan(double tongTien) 
    {
        double tienGiam = tongTien * this.tiLeGiamGia;
        double tienPhaiTra = tongTien - tienGiam;
        
        Console.WriteLine($"Khách thành viên [Cấp {this.capDo}] {this.hoTen} thanh toán. " +
                          $"Giảm {this.tiLeGiamGia * 100}% (-{tienGiam}đ).");
        
        return tienPhaiTra;
    }
}
