/* Bài 16: Mỗi một điểm trong mặt phẳng được xác đinh duy nhất bởi hai giá trị là hoành độ và
tung độ.
1. Hãy xây dựng lớp Diem cùng với chứa các đối tượng điểm trong mặt phẳng và xây dựng
phương thức sau:
-Toán tử tạo lập
- Phương thức in một đối tượng Diem
- Tính khoảng cách giữa hai điểm
2. Mỗi tam giác trong mặt phẳng được xác định bởi 3 điểm. Hãy xây dựng lớp TamGiac với 3
thuộc tính riêng là 3 đối tượng thuộc lớp Diem và các phương thức:
-Xây dựng các toản tử tạo lập: TamGiac(); TamGiac(Diem d1, Diem d2, Diem d3);
-Tính diện tích tam giác
- Tính chu vi của tam giác
3. Nhập vào một danh sách các tam giác, đưa ra tổng chu vi và tổng diện tích của các tam giác
vừa nhập. */


using System;
using System.Collections.Generic;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<TamGiac> danhSachTamGiac = new List<TamGiac>();
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập vào các tam giác
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin cho tam giác thứ {i + 1}:");

            Console.WriteLine("Nhập tọa độ điểm D1:");
            Console.Write("Nhập hoành độ x: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tọa độ điểm D2:");
            Console.Write("Nhập hoành độ x: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tọa độ điểm D3:");
            Console.Write("Nhập hoành độ x: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Nhập tung độ y: ");
            double y3 = double.Parse(Console.ReadLine());

            Diem d1 = new Diem(x1, y1);
            Diem d2 = new Diem(x2, y2);
            Diem d3 = new Diem(x3, y3);

            TamGiac tamGiac = new TamGiac(d1, d2, d3);
            danhSachTamGiac.Add(tamGiac);
        }

        // Tính tổng chu vi và tổng diện tích của các tam giác
        double tongChuVi = 0;
        double tongDienTich = 0;

        foreach (var tamGiac in danhSachTamGiac)
        {
            tongChuVi += tamGiac.TinhChuVi();
            tongDienTich += tamGiac.TinhDienTich();
        }

        Console.WriteLine($"\nTổng chu vi của các tam giác là: {tongChuVi}");
        Console.WriteLine($"Tổng diện tích của các tam giác là: {tongDienTich}");
    }
}
