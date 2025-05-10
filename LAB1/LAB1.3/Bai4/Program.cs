/* Bài 4: Để quản lý các hộ dân trong một khu phố, người ta quản lý các thông tin như sau:
-Với mỗi hộ dân, có các thuộc tính:
+Số thành viên trong hộ (số người)
+ Số nhà của hộ dân đó (số nhà được gắn cho mỗi hộ dân)
+ Thông tin về mỗi cá nhân trong hộ gia đình.
- Với mỗi cá nhân, người ta quản lý các thông tin như: số chứng minh nhân dân, họ và
tên, tuổi, năm sinh, nghề nghiệp.
1. Hãy xây dựng lớp Nguoi để quản lý thông tin về mỗi cá nhân.
2. Xây dựng lớp KhuPho để quản lý thông tin về các hộ gia đình.
3. Viết các phương thức nhập, hiển thị thông tin cho mỗi hộ gia đình.
4. Cài đặt chương trình thực hiện các công việc sau:
-Nhập vào một dãy gồm n hộ dân (n - nhập từ bàn phím).
- Tìm kiếm thông tin về hộ dân theo họ tên hoặc theo số nhà
- Hiển thị thông tin cho toàn bộ các hộ dân trong khu phố.
- Thoát khỏi chương trình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyHoDan quanLy = new QuanLyHoDan();
        quanLy.NhapThongTinHoDan();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Tìm kiếm hộ gia đình theo họ tên");
            Console.WriteLine("2. Tìm kiếm hộ gia đình theo số nhà");
            Console.WriteLine("3. Hiển thị thông tin tất cả các hộ gia đình");
            Console.WriteLine("4. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập họ tên để tìm kiếm: ");
                    string hoTenSearch = Console.ReadLine();
                    quanLy.TimKiemTheoHoTen(hoTenSearch);
                    break;

                case 2:
                    Console.Write("Nhập số nhà để tìm kiếm: ");
                    string soNhaSearch = Console.ReadLine();
                    quanLy.TimKiemTheoSoNha(soNhaSearch);
                    break;

                case 3:
                    quanLy.HienThiToanBoThongTin();
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

