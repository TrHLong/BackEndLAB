public class TaiLieu
{
    public string MaTaiLieu { get; set; }
    public string TenNhaXuatBan { get; set; }
    public int SoBanPhatHanh { get; set; }

    public TaiLieu(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh)
    {
        MaTaiLieu = maTaiLieu;
        TenNhaXuatBan = tenNhaXuatBan;
        SoBanPhatHanh = soBanPhatHanh;
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Mã tài liệu: {MaTaiLieu}");
        Console.WriteLine($"Tên nhà xuất bản: {TenNhaXuatBan}");
        Console.WriteLine($"Số bản phát hành: {SoBanPhatHanh}");
    }
}
