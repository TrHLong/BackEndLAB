// KhuPho.cs
using System;
using System.Collections.Generic;

public class KhuPho
{
    public string SoNha { get; set; }
    public List<Nguoi> DanhSachNguoi { get; set; }

    public KhuPho(string soNha)
    {
        SoNha = soNha;
        DanhSachNguoi = new List<Nguoi>();
    }

    public void ThemNguoi(Nguoi nguoi)
    {
        DanhSachNguoi.Add(nguoi);
    }

    public void HienThi()
    {
        Console.WriteLine($"Thông tin hộ gia đình tại số nhà {SoNha}:");
        foreach (var nguoi in DanhSachNguoi)
        {
            nguoi.HienThi();
        }
    }

    public Nguoi TimKiemTheoHoTen(string hoTen)
    {
        foreach (var nguoi in DanhSachNguoi)
        {
            if (nguoi.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
            {
                return nguoi;
            }
        }
        return null;
    }

    public Nguoi TimKiemTheoSoNha(string soNha)
    {
        if (this.SoNha.Equals(soNha, StringComparison.OrdinalIgnoreCase))
        {
            return DanhSachNguoi.Count > 0 ? DanhSachNguoi[0] : null; // giả sử mỗi nhà chỉ có một người tìm kiếm
        }
        return null;
    }
}
