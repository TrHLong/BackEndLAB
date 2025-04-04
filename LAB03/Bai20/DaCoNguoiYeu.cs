// DaCoNguoiYeu.cs
using System;

public class DaCoNguoiYeu : HoiVien
{
    public string NguoiYeu { get; set; }
    public string SoDienThoai { get; set; }

    // Toán tử tạo lập không có đối số
    public DaCoNguoiYeu() : base()
    {
        NguoiYeu = "";
        SoDienThoai = "";
    }

    // Toán tử tạo lập có đối số
    public DaCoNguoiYeu(string hoTen, string diaChi, string nguoiYeu, string soDienThoai)
        : base(hoTen, diaChi)
    {
        NguoiYeu = nguoiYeu;
        SoDienThoai = soDienThoai;
    }

    // Phương thức ghi đè in thông tin hội viên có người yêu
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine($"Người yêu: {NguoiYeu}, Số điện thoại: {SoDienThoai}");
    }
}
