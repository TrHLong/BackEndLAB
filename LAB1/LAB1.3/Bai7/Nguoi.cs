// Nguoi.cs
using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }
    public string SoCMND { get; set; }

    public Nguoi(string hoTen, int namSinh, string queQuan, string soCMND)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        QueQuan = queQuan;
        SoCMND = soCMND;
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Số CMND: {SoCMND}");
    }
}
