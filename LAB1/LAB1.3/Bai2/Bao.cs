public class Bao : TaiLieu
{
    public DateTime NgayPhatHanh { get; set; }

    public Bao(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, DateTime ngayPhatHanh)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        NgayPhatHanh = ngayPhatHanh;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngày phát hành: {NgayPhatHanh.ToString("dd/MM/yyyy")}");
    }
}
