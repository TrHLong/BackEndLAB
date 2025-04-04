/* Bài 17: Mỗi một điểm trong mặt phẳng được xác đinh duy nhất bởi hai giá trị là hoành độ và
tung độ.
1. Hãy xây dựng lớp Diem cùng với chứa các đối tượng diểm trong mặt phẳng và xây dựng
phương thức sau:
-Toán tử tạo lập
- Phương thức in một đối tượng thuộc lớp Diem
- Tính khoảng cách giữa hai điểm
2. Xây dựng lớp HinhTron chứa các đối tượng là các hình tròn với 2 thuộc tính là 1 đối tượng
thuộc lớp Diem để xác định tâm của hình tròn một giá trị nguyên để xác định bán kính của
hình tròn. Cài đặt các phương thức:
-Xây dựng các toán tử tạo lập: HinhTron(),
-HinhTron(Diem d, float bk)
- Tính chu vi, diện tich hình tròn;
-Nhập vào một danh sách các hình tròn, hiển thị thông tin về hình tròn giao với nhiều
hình tròn khác nhất trong danh sách những hình tròn đã nhập vào. */


using System;
using System.Collections.Generic;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<HinhTron> danhSachHinhTron = new List<HinhTron>();
        Console.Write("Nhập số lượng hình tròn: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập vào các hình tròn
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho hình tròn thứ {i + 1}:");

            Console.WriteLine("Nhập tọa độ tâm của hình tròn (hoành độ x, tung độ y):");
            Console.Write("Nhập hoành độ x: ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            float y = float.Parse(Console.ReadLine());

            Console.Write("Nhập bán kính của hình tròn: ");
            float banKinh = float.Parse(Console.ReadLine());

            Diem tam = new Diem(x, y);
            HinhTron hinhTron = new HinhTron(tam, banKinh);
            danhSachHinhTron.Add(hinhTron);
        }

        // Tính tổng chu vi và diện tích của các hình tròn
        float tongChuVi = 0;
        float tongDienTich = 0;

        foreach (var hinhTron in danhSachHinhTron)
        {
            tongChuVi += hinhTron.TinhChuVi();
            tongDienTich += hinhTron.TinhDienTich();
        }

        Console.WriteLine($"\nTổng chu vi của các hình tròn là: {tongChuVi}");
        Console.WriteLine($"Tổng diện tích của các hình tròn là: {tongDienTich}");

        // Tìm hình tròn giao với nhiều hình tròn khác nhất
        int maxGiao = 0;
        HinhTron hinhTronGiaoNhieu = null;

        foreach (var h1 in danhSachHinhTron)
        {
            int soGiao = 0;
            foreach (var h2 in danhSachHinhTron)
            {
                if (h1 != h2 && h1.KiemTraGiao(h2))
                {
                    soGiao++;
                }
            }

            if (soGiao > maxGiao)
            {
                maxGiao = soGiao;
                hinhTronGiaoNhieu = h1;
            }
        }

        Console.WriteLine("\nHình tròn giao với nhiều hình tròn khác nhất là:");
        if (hinhTronGiaoNhieu != null)
        {
            hinhTronGiaoNhieu.Tam.InDiem();
            Console.WriteLine($"Bán kính: {hinhTronGiaoNhieu.BanKinh}");
        }
        else
        {
            Console.WriteLine("Không có hình tròn nào giao với nhiều hình tròn khác.");
        }
    }
}
