namespace Badminton;
public class TaoBillThanhCongEvent : IEvent
{
    public KhachHang KhachHang{get;}
    public double TongTienDaThu{get;}
    public TaoBillThanhCongEvent(KhachHang khachHang, double tongTien)
    {
        KhachHang=khachHang;
        TongTienDaThu=tongTien;
    }
    public string GetEventName() => "TaoBillThanhCong";
}