// HSHocSinh.cs
using System;

public class HSHocSinh
{
    public string LopHoc { get; set; }
    public string KhoaHoc { get; set; }
    public string KyHoc { get; set; }
    public Nguoi HocSinh { get; set; }

    public HSHocSinh(string lopHoc, string khoaHoc, string kyHoc, Nguoi hocSinh)
    {
        LopHoc = lopHoc;
        KhoaHoc = khoaHoc;
        KyHoc = kyHoc;
        HocSinh = hocSinh;
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Lớp học: {LopHoc}, Khóa học: {KhoaHoc}, Kỳ học: {KyHoc}");
        HocSinh.HienThi();
    }

    public bool LaHocSinhNua1985()
    {
        return HocSinh.GioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase) && HocSinh.NamSinh == 1985;
    }

    public bool TimKiemTheoQueQuan(string queQuan)
    {
        return HocSinh.QueQuan.Equals(queQuan, StringComparison.OrdinalIgnoreCase);
    }
}
