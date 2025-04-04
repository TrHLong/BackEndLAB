/* Bài 13: Một công ty được giao nhiệm vụ quản lý các phương tiện giao thông gồm các loại: ô
tô, xe máy, xe tải.
+ mỗi loại phương tiện giao thông cần quản lý: Hãng sản xuất, năm sản xuất, giá bán
và màu.
+ Các ô tô cần quản lý: số chỗ ngồi, kiểu động cơ
+ Xe máy cần quản lý: công suất
+ Xe tải cần quản lý: trọng tải.
1.Xây dựng các lớp XeTai, XeMay, OTo kế thừa từ lớp PTGT.
2. Xây dựng các hàm để truy nhập, hiển thị và kiểm tra các thuộc tính của các lớp.
3. Xây dựng lớp QLPTGT cài đặt các phương thức thực hiện các chức năng sau:
-Nhập đăng ký phương tiện
- Tìm phương tiện theo màu hoặc theo năm sản xuất.
- Kết thúc chương trình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QLPTGT qlptgt = new QLPTGT();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\nChọn một chức năng:");
            Console.WriteLine("1. Nhập đăng ký phương tiện");
            Console.WriteLine("2. Tìm phương tiện theo màu hoặc năm sản xuất");
            Console.WriteLine("3. Kết thúc chương trình");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    qlptgt.NhapPhuongTien();
                    break;
                case 2:
                    qlptgt.TimPhuongTien();
                    break;
                case 3:
                    isRunning = false;
                    Console.WriteLine("Kết thúc chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
