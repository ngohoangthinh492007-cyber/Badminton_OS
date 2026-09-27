namespace Badminton;
public abstract class KhachHang 
{
    protected string maKhachHang;
    protected string hoTen;
    protected string soDienThoai;
    protected int diemTichLuy;

    public KhachHang(string maKhachHang, string hoTen, string soDienThoai, int diemTichLuy) 
    {
        this.maKhachHang = maKhachHang;
        this.hoTen = hoTen;
        this.soDienThoai = soDienThoai;
        this.diemTichLuy = diemTichLuy;
    }

    // Từ khóa virtual cho phép lớp con ghi đè logic cộng điểm nếu cần
    public virtual void TichDiem(int diem) 
    {
        this.diemTichLuy += diem;
        Console.WriteLine($"[Hệ thống] {this.hoTen} được cộng {diem} điểm. Tổng điểm hiện tại: {this.diemTichLuy}");
    }

    public string GetHoTen() => hoTen;

    // Phương thức trừu tượng: Ép buộc các loại khách hàng tự định nghĩa cách tính tiền
    public abstract double YeuCauThanhToan(double tongTien);
}
