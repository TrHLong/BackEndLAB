// CoQuan.cs
using System;

public class CoQuan : Nguoi
{
    public string DonViCongTac { get; set; }
    public double HeSoLuong { get; set; }

    // Toán tử tạo lập không có đối số
    public CoQuan() : base()
    {
        DonViCongTac = "";
        HeSoLuong = 1.0;
    }

    // Toán tử tạo lập có đối số
    public CoQuan(string hoTen, bool gioiTinh, int tuoi, string donViCongTac, double heSoLuong)
        : base(hoTen, gioiTinh, tuoi)
    {
        DonViCongTac = donViCongTac;
        HeSoLuong = heSoLuong;
    }

    // Phương thức ghi đè in thông tin cá nhân trong cơ quan
    public override void In()
    {
        base.In();
        Console.WriteLine($"Đơn vị công tác: {DonViCongTac}, Hệ số lương: {HeSoLuong}");
    }

    // Phương thức tính lương
    public double TinhLuong()
    {
        const double LUONG_CO_BAN = 1050000;  // Lương cơ bản
        return HeSoLuong * LUONG_CO_BAN;
    }
}
