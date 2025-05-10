/* Bài 19:
1.Xây dựng một lớp THISINH gồm các thông tin sau: Họ tên, quê quán, trường, tuổi, số
báo danh, điểm thi. Trong đó họ tên lại là một cấu trúc gồm ba thành phần: họ, tên đệm và tê.
Quê quán cũng là một cấu trúc gồm ba thàh phần: xã, huyện và tỉnh. Điểm thi là một cấu trúc
gồm ba thành phần: toán, lý, hoá (điểm chấm chính xác đến 1 / 4).
2. Đọc số liệu từ một phiếu điểm cụ thể và lưu trữ rồi sau đó in ra màn hình.
3. Xây dựng một danh sách các THISINH.
4. Nhập số liệu từ N phiếu điểm (N nhập vào từ bàn phím).
5. Tìm kiếm và in ra các thí sinh có tổng điểm ba môn lớn hơn 15.
6. Hãy lập chương trình sắp xếp lại danh sách theo tổng điểm ba môn giảm dần. Sau đó in
danh sách thông tin theo thứ tự nói trên. Hiển thị thông tin về các thí sinh theo dạng bảng, mỗi
thí sinh gồm các thông tin sau: Họ tên, Quê quán, Số báo danh, Điểm toán, lý, hoá */

using System;
using System.Collections.Generic;
using System.Linq;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<Thisinh> danhSachThisinh = new List<Thisinh>();
        Console.Write("Nhập số lượng thí sinh: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập thông tin cho n thí sinh
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho thí sinh thứ {i + 1}:");

            Console.Write("Nhập họ: ");
            string ho = Console.ReadLine();
            Console.Write("Nhập tên đệm: ");
            string tenDem = Console.ReadLine();
            Console.Write("Nhập tên: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập xã: ");
            string xa = Console.ReadLine();
            Console.Write("Nhập huyện: ");
            string huyen = Console.ReadLine();
            Console.Write("Nhập tỉnh: ");
            string tinh = Console.ReadLine();
            Console.Write("Nhập trường: ");
            string truong = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập số báo danh: ");
            string soBaoDanh = Console.ReadLine();
            Console.Write("Nhập điểm toán: ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            double ly = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            double hoa = double.Parse(Console.ReadLine());

            Thisinh thisinh = new Thisinh(ho, tenDem, ten, xa, huyen, tinh, truong, tuoi, soBaoDanh, toan, ly, hoa);
            danhSachThisinh.Add(thisinh);
        }

        // Tìm kiếm và in ra các thí sinh có tổng điểm lớn hơn 15
        Console.WriteLine("\nCác thí sinh có tổng điểm lớn hơn 15:");
        foreach (var thisinh in danhSachThisinh)
        {
            if (thisinh.TongDiem() > 15)
            {
                thisinh.InThongTin();
            }
        }

        // Sắp xếp danh sách thí sinh theo tổng điểm giảm dần
        var danhSachSapXep = danhSachThisinh.OrderByDescending(ts => ts.TongDiem()).ToList();

        Console.WriteLine("\nDanh sách thí sinh sau khi sắp xếp theo tổng điểm (giảm dần):");
        Console.WriteLine("Họ tên | Quê quán | Số báo danh | Điểm toán | Điểm lý | Điểm hóa");
        foreach (var thisinh in danhSachSapXep)
        {
            Console.WriteLine($"{thisinh.Hten.Ho} {thisinh.Hten.TenDem} {thisinh.Hten.Ten} | {thisinh.Qquan.Xa}, {thisinh.Qquan.Huyen}, {thisinh.Qquan.Tinh} | {thisinh.SoBaoDanh} | {thisinh.Diem.Toan:0.00} | {thisinh.Diem.Ly:0.00} | {thisinh.Diem.Hoa:0.00}");
        }
    }
}
