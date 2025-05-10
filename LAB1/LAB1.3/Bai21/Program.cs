/* Bài 21: Một trường trung học, học sinh bắt buộc phải học 3 môn toán, lý, hoá. Ngoài ra học
sinh nam học thêm môn kĩ thuật, học sinh nữ học thêm môn nữ công. Viết chương trình để:
1.Nhập họ tên, giới tính và điểm của n học sinh;
2.Hiển thị thông tin về những học sinh nam có điểm môn kĩ thuật không nhỏ hơn 8.
3. In số liệu về học sinh nam trước rồi đến các học sinh nữ */


using System;
using System.Collections.Generic;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        List<HocSinh> danhSachHocSinh = new List<HocSinh>();
        Console.Write("Nhập số lượng học sinh: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập thông tin cho n học sinh
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho học sinh thứ {i + 1}:");

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập giới tính (Nam/Nữ): ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Nhập điểm Toán: ");
            double diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Lý: ");
            double diemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhập điểm Hóa: ");
            double diemHoa = double.Parse(Console.ReadLine());

            if (gioiTinh.ToLower() == "nam")
            {
                Console.Write("Nhập điểm Kỹ thuật: ");
                double diemKyThuat = double.Parse(Console.ReadLine());

                HocSinhNam hocSinhNam = new HocSinhNam(hoTen, gioiTinh, diemToan, diemLy, diemHoa, diemKyThuat);
                danhSachHocSinh.Add(hocSinhNam);
            }
            else
            {
                Console.Write("Nhập điểm Nữ công: ");
                double diemNuCong = double.Parse(Console.ReadLine());

                HocSinhNu hocSinhNu = new HocSinhNu(hoTen, gioiTinh, diemToan, diemLy, diemHoa, diemNuCong);
                danhSachHocSinh.Add(hocSinhNu);
            }
        }

        // Tìm kiếm và hiển thị học sinh nam có điểm kỹ thuật >= 8
        Console.WriteLine("\nDanh sách học sinh nam có điểm kỹ thuật >= 8:");
        foreach (var hocSinh in danhSachHocSinh)
        {
            if (hocSinh is HocSinhNam && ((HocSinhNam)hocSinh).DiemKyThuat >= 8)
            {
                hocSinh.InThongTin();
            }
        }

        // Hiển thị thông tin học sinh theo giới tính
        Console.WriteLine("\nDanh sách học sinh theo thứ tự Nam trước, Nữ sau:");
        foreach (var hocSinh in danhSachHocSinh)
        {
            if (hocSinh is HocSinhNam)
            {
                hocSinh.InThongTin();
            }
        }

        foreach (var hocSinh in danhSachHocSinh)
        {
            if (hocSinh is HocSinhNu)
            {
                hocSinh.InThongTin();
            }
        }
    }
}
