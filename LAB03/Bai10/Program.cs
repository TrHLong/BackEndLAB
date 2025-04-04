/* Bài 10: Để xử lý các văn bản, người ta xây dựng lớp VanBan có thuộc tính riêng là một xâu
ký tự. Hãy:
1.Xây dựng các hàm tạo không có và có đối số như sau: VanBan(), VanBan(String st).
2.Xây dựng phương thức đếm số từ của một xâu.
3. Xây dựng phương thức đếm số ký tự H (không phân biệt chữ thường, chữ hoa) của xâu.
4. Chuẩn hoá một xâu theo tiêu chuẩn (Ở đầu và cuối của xâu không có ký tự trống, ở giữa
xâu không có hai ký tự trắng liền nhau).
5. Xây dựng một menu hỏi người sử dụng muốn thực hiện công việc gì (đếm từ, đếm số kí tự
H hãy chuẩn hóa sâu). Sau đó hiển thị kết quả ra màn hình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        Console.WriteLine("Nhập vào một xâu văn bản:");
        string input = Console.ReadLine();

        VanBan vanBan = new VanBan(input);

        bool isRunning = true;
        while (isRunning)
        {
            // Hiển thị menu cho người sử dụng
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Đếm số từ trong xâu");
            Console.WriteLine("2. Đếm số ký tự 'H' trong xâu");
            Console.WriteLine("3. Chuẩn hóa xâu");
            Console.WriteLine("4. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int soTu = vanBan.DemSoTu();
                    Console.WriteLine("Số từ trong xâu: " + soTu);
                    break;

                case 2:
                    int soKyTuH = vanBan.DemSoKyTuH();
                    Console.WriteLine("Số ký tự 'H' trong xâu: " + soKyTuH);
                    break;

                case 3:
                    vanBan.ChuanHoaXau();
                    vanBan.HienThi();
                    break;

                case 4:
                    isRunning = false;
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}

