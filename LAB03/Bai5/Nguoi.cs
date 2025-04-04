// Nguoi.cs
using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string SoCMND { get; set; }

    public Nguoi(string hoTen, int namSinh, string soCMND)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        SoCMND = soCMND;
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Số CMND: {SoCMND}");
    }
}
