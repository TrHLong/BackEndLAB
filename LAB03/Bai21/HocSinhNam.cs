// HocSinhNam.cs
using System;

public class HocSinhNam : HocSinh
{
    public double DiemKyThuat { get; set; }

    // Toán tử tạo lập không có đối số
    public HocSinhNam() : base()
    {
        DiemKyThuat = 0;
    }

    // Toán tử tạo lập có đối số
    public HocSinhNam(string hoTen, string gioiTinh, double diemToan, double diemLy, double diemHoa, double diemKyThuat)
        : base(hoTen, gioiTinh, diemToan, diemLy, diemHoa)
    {
        DiemKyThuat = diemKyThuat;
    }

    // Phương thức ghi đè in thông tin về học sinh nam
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine($"Điểm kỹ thuật: {DiemKyThuat}");
    }
}
