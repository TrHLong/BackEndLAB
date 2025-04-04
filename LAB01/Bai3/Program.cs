//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F
//Công thức: F = (C * 9 / 5) + 32
using System;
using LAB01;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập nhiệt độ (°C): ");
                string? celsiusInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(celsiusInput))
                    throw new ArgumentException("Nhiệt độ không được để trống.");

                if (!double.TryParse(celsiusInput, out double celsius))
                    throw new ArgumentException("Giá trị nhập vào không hợp lệ. Phải là số.");

                double fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
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
