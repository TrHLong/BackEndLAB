/* Bài 6: Để quản lý hồ sơ học sinh của trường THPT, người ta cần quản lý những thông tin như
sau:
-Các thông tin về : lớp, khoá học, kỳ học, và các thông tin cá nhân của mỗi học sinh.
- Với mỗi học sinh, các thông tin cá nhân cần quản lý gồm có: Họ và tên, tuổi, năm
sinh, quê quán, giới tính.
1. Hãy xây dựng lớp Nguoi để quản lý các thông tin cá nhân của mỗi học sinh.
2. Xây dựng lớp HSHocSinh (hồ sơ học sinh) để lý các thông tin về mỗi học sinh.
3. Xây dựng các phương thức : nhập, hiển thị các thông tin về hồ sơ cá nhân của mỗi học sinh.
4. Cài đặt chương trình thực hiện các công việc sau:
-Nhập vào một danh sách gồm n học sinh ( n- nhập từ bàn phím)
- Hiển thị ra màn hình tất cả những học sinh nữ và sinh năm 1985.
- Tìm kiếm học sinh theo quê quán.
- Thoát khỏi chương trình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyHocSinh quanLyHocSinh = new QuanLyHocSinh();
        quanLyHocSinh.NhapThongTinHocSinh();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Hiển thị thông tin học sinh nữ sinh năm 1985");
            Console.WriteLine("2. Tìm kiếm học sinh theo quê quán");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    quanLyHocSinh.HienThiHocSinhNuSinh1985();
                    break;

                case 2:
                    Console.Write("Nhập quê quán để tìm kiếm: ");
                    string queQuanSearch = Console.ReadLine();
                    quanLyHocSinh.TimKiemHocSinhTheoQueQuan(queQuanSearch);
                    break;

                case 3:
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
