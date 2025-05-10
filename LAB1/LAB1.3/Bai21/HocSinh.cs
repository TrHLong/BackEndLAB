// HocSinh.cs
using System;

public class HocSinh
{
    public string HoTen { get; set; }
    public string GioiTinh { get; set; }
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    // Toán tử tạo lập không có đối số
    public HocSinh()
    {
        HoTen = "";
        GioiTinh = "";
        DiemToan = 0;
        DiemLy = 0;
        DiemHoa = 0;
    }

    // Toán tử tạo lập có đối số
    public HocSinh(string hoTen, string gioiTinh, double diemToan, double diemLy, double diemHoa)
    {
        HoTen = hoTen;
        GioiTinh = gioiTinh;
        DiemToan = diemToan;
        DiemLy = diemLy;
        DiemHoa = diemHoa;
    }

    // Phương thức in thông tin về học sinh
    public virtual void InThongTin()
    {
        Console.WriteLine($"Họ tên: {HoTen}, Giới tính: {GioiTinh}, Toán: {DiemToan}, Lý: {DiemLy}, Hóa: {DiemHoa}");
    }
}
