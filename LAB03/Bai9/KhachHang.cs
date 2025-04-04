// KhachHang.cs
using System;

public class KhachHang
{
    public string HoTen { get; set; }
    public string SoNha { get; set; }
    public string MaSoCongTo { get; set; }

    public KhachHang(string hoTen, string soNha, string maSoCongTo)
    {
        HoTen = hoTen;
        SoNha = soNha;
        MaSoCongTo = maSoCongTo;
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên chủ hộ: {HoTen}, Số nhà: {SoNha}, Mã số công tơ: {MaSoCongTo}");
    }
}
