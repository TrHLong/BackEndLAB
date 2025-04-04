//Bài 2: Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử
//là số nguyên tố trong mảng.

using System;
using LAB02.Common;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();
            try
            {
                Console.Write("Nhập số phần tử của mảng: ");
                int n;
                while (true)
                {
                    try
                    {
                        n = int.Parse(Console.ReadLine()!);  // Dùng Parse và bắt lỗi nếu nhập sai
                        if (n <= 0)
                        {
                            Console.WriteLine("Số phần tử phải là số nguyên dương (> 0).");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên.");
                    }
                }

                object[] arr = new object[n];

                // Nhập các phần tử của mảng
                for (int i = 0; i < n; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Nhập phần tử thứ {i + 1}: ");
                            string input = Console.ReadLine()!;
                            arr[i] = ParseInput(input); // Phân tích đầu vào
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi nhập: {ex.Message}");
                        }
                    }
                }

                // Kiểm tra và hiển thị các số nguyên tố
                bool hasPrime = false;
                Console.WriteLine("Các số nguyên tố trong mảng:");
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] is int num && IsPrime(num))
                    {
                        Console.WriteLine($"Chỉ số: {i+1}, Giá trị: {num}");
                        hasPrime = true;
                    }
                }

                if (!hasPrime)
                {
                    Console.WriteLine("Mảng không có số nguyên tố.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }
        }

        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Hàm để phân tích và kiểm tra loại nhập vào
        static object ParseInput(string input)
        {
            if (int.TryParse(input, out int intValue))
            {
                return intValue;
            }
            else if (double.TryParse(input, out double doubleValue))
            {
                return doubleValue;
            }
            else
            {
                throw new Exception("Phần tử không phải là số hợp lệ.");
            }
        }
    }
}
