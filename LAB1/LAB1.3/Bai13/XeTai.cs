// XeTai.cs
using System;

public class XeTai : PTGT
{
    public double TrongTai { get; set; }

    public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai)
        : base(hangSanXuat, namSanXuat, giaBan, mau)
    {
        TrongTai = trongTai;
    }

    public new void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Trọng tải: {TrongTai} tấn");
    }
}
