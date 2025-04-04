// DaCoGiaDinh.cs
using System;

public class DaCoGiaDinh : HoiVien
{
    public string VoChong { get; set; }
    public DateTime NgayCuoi { get; set; }

    // Toán tử tạo lập không có đối số
    public DaCoGiaDinh() : base()
    {
        VoChong = "";
        NgayCuoi = DateTime.MinValue;
    }

    // Toán tử tạo lập có đối số
    public DaCoGiaDinh(string hoTen, string diaChi, string voChong, DateTime ngayCuoi)
        : base(hoTen, diaChi)
    {
        VoChong = voChong;
        NgayCuoi = ngayCuoi;
    }

    // Phương thức ghi đè in thông tin hội viên đã có gia đình
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine($"Vợ/chồng: {VoChong}, Ngày cưới: {NgayCuoi:dd/MM/yyyy}");
    }
}
