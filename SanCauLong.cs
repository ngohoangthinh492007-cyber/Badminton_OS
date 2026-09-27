namespace Badminton;
public class SanCauLong 
{
    private string maSan;
    private double giaThueMoiGio;

    public SanCauLong(string maSan, double gia) 
    {
        this.maSan = maSan;
        this.giaThueMoiGio = gia;
    }
    public double GetGiaThu() => giaThueMoiGio;
}