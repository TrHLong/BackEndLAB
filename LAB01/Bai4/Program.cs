//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn
//hay không.

using System;
using LAB01;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập một số nguyên: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Không được để trống.");

                // Kiểm tra có phải là số nguyên int hay không
                if (!int.TryParse(input, out int number))
                    throw new ArgumentException("Giá trị nhập không hợp lệ. Vui lòng nhập một số nguyên.");

                // Kiểm tra chẵn / lẻ
                if (number % 2 == 0)
                    Console.WriteLine($"{number} là số chẵn.");
                else
                    Console.WriteLine($"{number} là số lẻ.");
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
