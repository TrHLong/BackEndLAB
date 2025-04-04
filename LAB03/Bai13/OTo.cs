// OTo.cs
using System;

public class OTo : PTGT
{
    public int SoChoNgoi { get; set; }
    public string KieuDongCo { get; set; }

    public OTo(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soChoNgoi, string kieuDongCo)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        SoChoNgoi = soChoNgoi;
        KieuDongCo = kieuDongCo;
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Số chỗ ngồi: {SoChoNgoi}, Kiểu động cơ: {KieuDongCo}");
    }
}
