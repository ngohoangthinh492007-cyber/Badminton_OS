namespace Badminton
{
    // 1. Abstract Class DichVu
    public abstract class DichVu
    {
        public string MaDV { get; }
        public string TenDV { get; }
        public double DonGia { get; }
        public int SoLuongTon { get; set; }

        public DichVu(string ma, string ten, double gia, int tonKho = 999)
        {
            MaDV = ma;
            TenDV = ten;
            DonGia = gia;
            SoLuongTon = tonKho;
        }
