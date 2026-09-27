namespace Badminton;
public class ThanhToanTienMat : IThanhToan 
{
    public bool ThucHienThanhToan(double tongTien) 
    {
        Console.WriteLine($"=> Đã nhận {tongTien}đ bằng TIỀN MẶT.");
        return true;
    }
}