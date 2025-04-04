// Nguoi.cs
using System;

public class Nguoi
{
    public string HoTen { get; set; }
    public bool GioiTinh { get; set; }  // true là nam, false là nữ
    public int Tuoi { get; set; }

    // Toán tử tạo lập không có đối số
    public Nguoi()
    {
        HoTen = "";
        GioiTinh = true;  // mặc định là nam
        Tuoi = 0;
    }

    // Toán tử tạo lập có đối số
    public Nguoi(string hoTen, bool gioiTinh, int tuoi)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        Tuoi = tuoi;
    }

    // Phương thức in thông tin cá nhân
    public virtual void In()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {(GioiTinh ? "Nam" : "Nữ")}, Tuổi: {Tuoi}");
    }
}
