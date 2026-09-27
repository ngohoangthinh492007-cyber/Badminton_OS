namespace Badminton;
public class DichVuHangHoa : DichVu
{
    private int soLuongTon;
    public DichVuHangHoa(string maDV, string tenDV, double donGia, int soLuongTon) : base(maDV, tenDV, donGia)
    {
        this.soLuongTon=soLuongTon; 
    }
}