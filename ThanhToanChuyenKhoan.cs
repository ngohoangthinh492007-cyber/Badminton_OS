namespace Badminton;
public class ThanhToanChuyenKhoan : IThanhToan 
{
    public bool ThucHienThanhToan(double tongTien) 
    {
        Console.WriteLine($"=> Đã nhận {tongTien}đ qua CHUYỂN KHOẢN (VietQR).");
        return true;
    }
}