//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n

using System;
using LAB01;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập một số nguyên dương: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Không được để trống.");

                if (!int.TryParse(input, out int n))
                    throw new ArgumentException("Vui lòng nhập một số nguyên hợp lệ.");

                if (n <= 0)
                    throw new ArgumentException("Số phải là một số nguyên dương (> 0).");

                // Tính giai thừa
                long giaiThua = 1;
                for (int i = 1; i <= n; i++)
                {
                    giaiThua *= i;
                }

                Console.WriteLine($"{n}! = {giaiThua}");
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
