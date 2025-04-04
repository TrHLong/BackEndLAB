// SinhVien.cs
using System;

public class SinhVien
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string Lop { get; set; }
    public string MaSoSinhVien { get; set; }

    public SinhVien(string hoTen, int namSinh, string lop, string maSoSinhVien)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        Lop = lop;
        MaSoSinhVien = maSoSinhVien;
    }

    public void HienThi()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Năm sinh: {NamSinh}, Lớp: {Lop}, Mã số sinh viên: {MaSoSinhVien}");
    }
}
