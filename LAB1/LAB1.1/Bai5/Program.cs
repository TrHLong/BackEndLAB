//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.

using System;
using LAB01;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                // Nhập số thứ nhất
                Console.Write("Nhập số thứ nhất: ");
                string? inputA = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputA))
                    throw new ArgumentException("Số thứ nhất không được để trống.");

                if (!double.TryParse(inputA, out double a))
                    throw new ArgumentException("Số thứ nhất không hợp lệ. Vui lòng nhập một số.");

                // Nhập số thứ hai
                Console.Write("Nhập số thứ hai: ");
                string? inputB = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputB))
                    throw new ArgumentException("Số thứ hai không được để trống.");

                if (!double.TryParse(inputB, out double b))
                    throw new ArgumentException("Số thứ hai không hợp lệ. Vui lòng nhập một số.");

                // Tính toán
                double tong = a + b;
                double tich = a * b;

                Console.WriteLine($"Tổng của {a} và {b} là: {tong}");
                Console.WriteLine($"Tích của {a} và {b} là: {tich}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }
        }
    }
}
