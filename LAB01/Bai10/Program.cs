//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.

using System;
using LAB01;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập một số: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Không được để trống.");

                if (!int.TryParse(input, out int number))
                    throw new ArgumentException("Vui lòng nhập một số nguyên hợp lệ.");

                // Kiểm tra nguyên tố
                if (IsPrime(number))
                    Console.WriteLine($"{number} là số nguyên tố.");
                else
                    Console.WriteLine($"{number} không phải là số nguyên tố.");
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

        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
