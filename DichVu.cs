namespace Badminton;
public abstract class DichVu
{
    protected string maDV;
    protected string tenDV;
    protected double donGia;
    public DichVu(string maDV, string tenDV, double donGia)
    {
        this.maDV=maDV;
        this.tenDV=tenDV;
        this.donGia=donGia;
    }
    public double GetDonGia() => donGia;
    public string GetTenDv() => tenDV;
}