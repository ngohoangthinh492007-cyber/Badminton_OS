namespace Badminton;
public class DichVuChoThue : DichVu
{
    private string tinhTrangVatDung;
    public DichVuChoThue(string maDV, string tenDV, double donGia, string tinhTrangVatDung):base(maDV, tenDV, donGia)
    {
        this.tinhTrangVatDung=tinhTrangVatDung;
    }
}