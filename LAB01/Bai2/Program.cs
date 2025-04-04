//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và
//chiều rộng.
using System;
using LAB01;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.SetupConsole();

            try
            {
                Console.Write("Nhập chiều dài: ");
                string? inputDai = Console.ReadLine();
                double dai = double.Parse(inputDai!); // sẽ ném FormatException nếu rỗng hoặc sai

                if (dai <= 0)
                    throw new ArgumentException("Chiều dài phải lớn hơn 0.");

                Console.Write("Nhập chiều rộng: ");
                string? inputRong = Console.ReadLine();
                double rong = double.Parse(inputRong!);

                if (rong <= 0)
                    throw new ArgumentException("Chiều rộng phải lớn hơn 0.");

                double dientich = dai * rong;
                Console.WriteLine($"Diện tích hình chữ nhật là: {dientich}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị nhập vào phải là số hợp lệ.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
    }
}
