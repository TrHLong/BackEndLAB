/* Bài 7: Khoa Công nghệ thông tin - Trường Đại Học Đại Nam cần quản lý việc thanh toán
tiền lương cho các cán bộ giáo viên trong khoa. Để quản lý được, thì nhà quản lý cần có những
thông tin như sau:
-Với mỗi cán bộ giáo viên, có các thông tin chung như sau: lương cứng, thưởng, phạt,
lương thực lĩnh
và các thông tin cá nhân của mỗi cán bộ giáo viên
- Các thông tin cá nhân của mỗi cán bộ giáo viên: Họ và tên, năm sinh, quê quán, số
chứng minh thư
nhân dân.
1. Hãy xây dựng lớp Nguoi để quản lý các thông tin cá nhân về mỗi cán bộ giáo viên
2. Xây dựng lớp CBGV (cán bộ giáo viên) để quản lý các thông tin chung về mỗi cán bộ giáo
viên
3. Xây dựng các phương thức: nhập, hiển thị các thông tin cá nhân của mỗi cán bộ giáo viên
4. Tính lương thực lĩnh cho mỗi cán bộ nếu công thức tính lương được tính như sau:
Lương thực lĩnh=Lương cứng + thưởng - phạt
5. Nhập vào một danh sách các cán bộ giáo viên, thực hiện các công việc sau:
-Tìm kiếm thông tin về cán bộ giáo viên theo quê quán;
-Hiển thị thông tin về các cán bộ giáo viên có lương thực lĩnh trên 5 triệu đồng một
tháng.
- Thoát khỏi chương trình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyCBGV quanLyCBGV = new QuanLyCBGV();
        quanLyCBGV.NhapThongTinCBGV();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Tìm kiếm cán bộ giáo viên theo quê quán");
            Console.WriteLine("2. Hiển thị thông tin các cán bộ giáo viên có lương thực lĩnh trên 5 triệu");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập quê quán để tìm kiếm: ");
                    string queQuanSearch = Console.ReadLine();
                    quanLyCBGV.TimKiemCBGVTheoQueQuan(queQuanSearch);
                    break;

                case 2:
                    quanLyCBGV.HienThiCBGVLuongTren5Trieu();
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

