public class TapChi : TaiLieu
{
    public int SoPhatHanh { get; set; }
    public int ThangPhatHanh { get; set; }

    public TapChi(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, int soPhatHanh, int thangPhatHanh)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        SoPhatHanh = soPhatHanh;
        ThangPhatHanh = thangPhatHanh;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Số phát hành: {SoPhatHanh}");
        Console.WriteLine($"Tháng phát hành: {ThangPhatHanh}");
    }
}
