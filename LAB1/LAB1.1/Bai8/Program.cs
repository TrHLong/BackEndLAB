//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.

using System;
using LAB01;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.WriteLine("Bảng cửu chương từ 1 đến 10:\n");

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"--- Bảng nhân {i} ---");
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine($"{i} x {j} = {i * j}");
                    }
                    Console.WriteLine(); // dòng trống sau mỗi bảng
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }
        }
    }
}
