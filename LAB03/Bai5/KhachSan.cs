// KhachSan.cs
using System;
using System.Collections.Generic;

public class KhachSan
{
    public string LoaiPhong { get; set; }
    public double GiaPhong { get; set; }
    public int SoNgayTro { get; set; }
    public Nguoi Khach { get; set; }

    public KhachSan(string loaiPhong, double giaPhong, int soNgayTro, Nguoi khach)
    {
        LoaiPhong = loaiPhong;
        GiaPhong = giaPhong;
        SoNgayTro = soNgayTro;
        Khach = khach;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Loại phòng: {LoaiPhong}, Giá phòng: {GiaPhong} VND, Số ngày trọ: {SoNgayTro} ngày");
        Khach.HienThi();
    }

    public double TinhTienThanhToan()
    {
        return GiaPhong * SoNgayTro;
    }

    public bool TimKiemTheoHoTen(string hoTen)
    {
        return Khach.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase);
    }
}
