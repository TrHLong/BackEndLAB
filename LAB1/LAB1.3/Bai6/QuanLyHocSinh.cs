// QuanLyHocSinh.cs
using System;
using System.Collections.Generic;

public class QuanLyHocSinh
{
    public List<HSHocSinh> DanhSachHocSinh { get; set; }

    public QuanLyHocSinh()
    {
        DanhSachHocSinh = new List<HSHocSinh>();
    }

    public void NhapThongTinHocSinh()
    {
        Console.WriteLine("Nhập số lượng học sinh:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.Write("Quê quán: ");
            string queQuan = Console.ReadLine();

            Console.Write("Giới tính: ");
            string gioiTinh = Console.ReadLine();

            Nguoi hocSinh = new Nguoi(hoTen, tuoi, namSinh, queQuan, gioiTinh);

            Console.Write("Lớp học: ");
            string lopHoc = Console.ReadLine();

            Console.Write("Khóa học: ");
            string khoaHoc = Console.ReadLine();

            Console.Write("Kỳ học: ");
            string kyHoc = Console.ReadLine();

            HSHocSinh hsHocSinh = new HSHocSinh(lopHoc, khoaHoc, kyHoc, hocSinh);
            DanhSachHocSinh.Add(hsHocSinh);
        }
    }

    public void HienThiHocSinhNuSinh1985()
    {
        Console.WriteLine("\nDanh sách học sinh nữ sinh năm 1985:");
        foreach (var hs in DanhSachHocSinh)
        {
            if (hs.LaHocSinhNua1985())
            {
                hs.HienThiThongTin();
            }
        }
    }

    public void TimKiemHocSinhTheoQueQuan(string queQuan)
    {
        bool found = false;
        Console.WriteLine($"\nTìm kiếm học sinh theo quê quán: {queQuan}");
        foreach (var hs in DanhSachHocSinh)
        {
            if (hs.TimKiemTheoQueQuan(queQuan))
            {
                hs.HienThiThongTin();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Không tìm thấy học sinh nào với quê quán này.");
        }
    }
}
