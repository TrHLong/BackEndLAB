/* Bài 22: Nhập danh sách n học sinh viết dưới dạng các thuộc tính: họ tên, năm sinh và tổng
điểm. Sắp xếp theo thứ tự giảm dần của tổng điểm. Khi tổng điểm như nhau thì học sinh có
năm sinh nhỏ hơn được đứng trước. In ra danh sách học sinh đã sắp xếp sao cho tất cả các chữ
cái đầu của họ tên chuyển thành chữ hoa. */


using System;
using System.Collections.Generic;
using System.Linq;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<HocSinh> danhSachHocSinh = new List<HocSinh>();
        Console.Write("Nhập số lượng học sinh: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập thông tin cho n học sinh
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tổng điểm: ");
            double tongDiem = double.Parse(Console.ReadLine());

            HocSinh hocSinh = new HocSinh(hoTen, namSinh, tongDiem);
            danhSachHocSinh.Add(hocSinh);
        }

        // Sắp xếp danh sách học sinh theo tổng điểm giảm dần, nếu tổng điểm bằng nhau thì sắp xếp theo năm sinh tăng dần
        var danhSachSapXep = danhSachHocSinh.OrderByDescending(hs => hs.TongDiem)
                                              .ThenBy(hs => hs.NamSinh)
                                              .ToList();

        // In ra danh sách học sinh đã sắp xếp
        Console.WriteLine("\nDanh sách học sinh đã sắp xếp:");
        foreach (var hocSinh in danhSachSapXep)
        {
            hocSinh.InThongTin();
        }
    }
}
