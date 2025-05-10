//Bài 1: Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào
//[tên], bạn[tuổi] tuổi!".
using System;
using LAB01;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                // --- Nhập tên ---
                Console.Write("Nhập tên: ");
                string? name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("Tên không được để trống.");

                // Kiểm tra nếu tên chỉ là số (ví dụ: "1234")
                if (int.TryParse(name, out _))
                    throw new ArgumentException("Tên không hợp lệ. Vui lòng nhập chữ cái.");

                // --- Nhập tuổi ---
                Console.Write("Nhập tuổi: ");
                string? ageInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ageInput))
                    throw new ArgumentException("Tuổi không được để trống.");

                if (!int.TryParse(ageInput, out int age))
                    throw new ArgumentException("Tuổi phải là số nguyên.");

                if (age <= 0)
                    throw new ArgumentException("Tuổi phải là số nguyên dương (> 0).");

                // --- Kết quả ---
                Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");
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
