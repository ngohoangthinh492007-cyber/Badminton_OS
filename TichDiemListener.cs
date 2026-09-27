namespace Badminton;
public class TichDiemListener : IEventListener 
{
    public void HandleEvent(IEvent e) 
    {
        if (e is TaoBillThanhCongEvent billEvent) 
        {
            // Quy đổi: Cứ 10.000đ thanh toán = 1 điểm
            int diemThuong = (int)(billEvent.TongTienDaThu / 10000);
            billEvent.KhachHang.TichDiem(diemThuong);
        }
    }
}