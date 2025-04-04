//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số
//không.

using System;
using LAB01;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập một số bất kỳ: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Không được để trống.");

                if (!double.TryParse(input, out double number))
                    throw new ArgumentException("Giá trị nhập không hợp lệ. Vui lòng nhập một số.");

                // Kiểm tra âm / dương / bằng 0
                if (number > 0)
                    Console.WriteLine($"{number} là số dương.");
                else if (number < 0)
                    Console.WriteLine($"{number} là số âm.");
                else
                    Console.WriteLine("Số vừa nhập là 0.");
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
