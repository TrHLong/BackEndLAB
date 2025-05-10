// XeMay.cs
using System;

public class XeMay : PTGT
{
    public double CongSuat { get; set; }

    public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, double congSuat)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        CongSuat = congSuat;
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Công suất: {CongSuat} mã lực");
    }
}
