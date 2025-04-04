/* Bài 15:
1.Hãy xây dựng lớp DaGiac gồm có các thuộc tính
- Số cạnh của đa giác
- Mảng các số nguyên chứa kích thước các cạnh của đa giác
Các phương thức:
-Tính chu vi
- In giá trị các cạnh của đa giác.
2. Xây dựng lớp TamGiac kế thừa từ lớp DaGiac, trong đó viết đè hàm tính chu vi và xây dựng
thêm phương thức tính diện tích tam giác
3. Xây dựng một ứng dụng để nhập vào một dãy gồm n tam giác rồi in ra màn hình các cạnh
của các tam giác thỏa mãn định lý Pitago. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        Console.Write("Nhập số lượng tam giác: ");
        int n = int.Parse(Console.ReadLine());

        TamGiac[] tamGiacs = new TamGiac[n];

        // Nhập vào các tam giác
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập tam giác thứ {i + 1}:");

            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            tamGiacs[i] = new TamGiac(a, b, c);
        }

        Console.WriteLine("\nCác tam giác thỏa mãn định lý Pitago:");
        // Kiểm tra và hiển thị các tam giác thỏa mãn định lý Pitago
        foreach (var tamGiac in tamGiacs)
        {
            if (tamGiac.KiemTraDinhLyPitago())
            {
                tamGiac.InCacCanh();
                Console.WriteLine($"Chu vi: {tamGiac.TinhChuVi()}");
                Console.WriteLine($"Diện tích: {tamGiac.TinhDienTich():0.00}");
                Console.WriteLine();
            }
        }
    }
}
