// Nguoi.cs
using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public int NamSinh { get; set; }
    public string QueQuan { get; set; }
    public string GioiTinh { get; set; }

    public Nguoi(string hoTen, int tuoi, int namSinh, string queQuan, string gioiTinh)
    {
        HoTen = hoTen;
        Tuoi = tuoi;
        NamSinh = namSinh;
        QueQuan = queQuan;
        GioiTinh = gioiTinh;
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Tuổi: {Tuoi}, Năm sinh: {NamSinh}, Quê quán: {QueQuan}, Giới tính: {GioiTinh}");
    }
}
