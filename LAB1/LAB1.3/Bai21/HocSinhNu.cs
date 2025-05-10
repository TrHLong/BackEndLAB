// HocSinhNu.cs
using System;

public class HocSinhNu : HocSinh
{
    public double DiemNuCong { get; set; }

    // Toán tử tạo lập không có đối số
    public HocSinhNu() : base()
    {
        DiemNuCong = 0;
    }

    // Toán tử tạo lập có đối số
    public HocSinhNu(string hoTen, string gioiTinh, double diemToan, double diemLy, double diemHoa, double diemNuCong)
        : base(hoTen, gioiTinh, diemToan, diemLy, diemHoa)
    {
        DiemNuCong = diemNuCong;
    }

    // Phương thức ghi đè in thông tin về học sinh nữ
    public override void InThongTin()
    {
        base.InThongTin();
        Console.WriteLine($"Điểm nữ công: {DiemNuCong}");
    }
}
