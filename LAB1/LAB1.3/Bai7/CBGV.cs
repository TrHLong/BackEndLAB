// CBGV.cs
using System;

public class CBGV
{
    public double LuongCung { get; set; }
    public double Thuong { get; set; }
    public double Phat { get; set; }
    public double LuongThucLinh => LuongCung + Thuong - Phat; // Tính lương thực lĩnh
    public Nguoi CanBo { get; set; }

    public CBGV(double luongCung, double thuong, double phat, Nguoi canBo)
    {
        LuongCung = luongCung;
        Thuong = thuong;
        Phat = phat;
        CanBo = canBo;
    }

    public void HienThiThongTin()
    {
        CanBo.HienThi();
        Console.WriteLine($"Lương cứng: {LuongCung} VND, Thưởng: {Thuong} VND, Phạt: {Phat} VND, Lương thực lĩnh: {LuongThucLinh} VND");
    }

    public bool LươngThucLinhTren5Trieu()
    {
        return LuongThucLinh > 5000000;
    }

    public bool TimKiemTheoQueQuan(string queQuan)
    {
        return CanBo.QueQuan.Equals(queQuan, StringComparison.OrdinalIgnoreCase);
    }
}
