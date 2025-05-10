// HoiVien.cs
using System;

public class HoiVien
{
    public string HoTen { get; set; }
    public string DiaChi { get; set; }

    // Toán tử tạo lập không có đối số
    public HoiVien()
    {
        HoTen = "";
        DiaChi = "";
    }

    // Toán tử tạo lập có đối số
    public HoiVien(string hoTen, string diaChi)
    {
        HoTen = hoTen;
        DiaChi = diaChi;
    }

    // Phương thức in thông tin hội viên
    public virtual void InThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Địa chỉ: {DiaChi}");
    }
}
