//Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho
//400).

using System;
using LAB01;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập một năm: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Không được để trống.");

                if (!int.TryParse(input, out int year))
                    throw new ArgumentException("Giá trị nhập không hợp lệ. Vui lòng nhập số nguyên dương.");

                if (year <= 0)
                    throw new ArgumentException("Năm phải là số nguyên dương (> 0).");

                // Kiểm tra năm nhuận
                bool isLeapYear = (year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0));

                if (isLeapYear)
                    Console.WriteLine($"{year} là năm nhuận.");
                else
                    Console.WriteLine($"{year} không phải là năm nhuận.");
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
