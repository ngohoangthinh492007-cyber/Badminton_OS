namespace Badminton;
public class KhachVangLai : KhachHang 
{
    public KhachVangLai(string maKhachHang, string hoTen, string soDienThoai, int diemTichLuy) 
        : base(maKhachHang, hoTen, soDienThoai, diemTichLuy) 
    {
    }

    public override double YeuCauThanhToan(double tongTien) 
    {
        Console.WriteLine($"Khách vãng lai {this.hoTen} thanh toán. Không áp dụng giảm giá.");
        return tongTien; // Trả 100% tiền
    }
}