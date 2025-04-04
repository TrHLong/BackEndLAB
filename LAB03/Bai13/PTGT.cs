// PTGT.cs
using System;

public class PTGT
{
    public string HangSanXuat { get; set; }
    public int NamSanXuat { get; set; }
    public double GiaBan { get; set; }
    public string Mau { get; set; }

    public PTGT(string hangSanXuat, int namSanXuat, double giaBan, string mau)
    {
        HangSanXuat = hangSanXuat;
        NamSanXuat = namSanXuat;
        GiaBan = giaBan;
        Mau = mau;
    }

    public void HienThi()
    {
        Console.WriteLine($"Hãng sản xuất: {HangSanXuat}, Năm sản xuất: {NamSanXuat}, Giá bán: {GiaBan} VND, Màu: {Mau}");
    }
}
