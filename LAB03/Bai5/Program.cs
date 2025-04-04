/* Bài 5: Để quản lý khách hàng đến thuê phòng của một khách sạn, người ta cần quản lý những
thông tin sau:
-Số ngày trọ, loại phòng trọ, giá phòng, và các thông tin cá nhân về mỗi khách trọ.
- Với mỗi cá nhân, người ta cần quản lý các thông tin : Họ và tên, năm sinh, số chứng
minh thư nhân dân.
1. Hãy xây dựng lớp Nguoi để quản lý thông tin cá nhân về mỗi cá nhân.
2. Xây dựng lớp KhachSan để quản lý các thông tin về khách thuê phòng.
3. Viết các phương thức : nhập, hiển thị các thông tin về mỗi khách thuê phòng.
4. Cài đặt chương trình thực hiện các công việc sau:
-Nhập vào một dãy gồm n khách trọ ( n - nhập từ bàn phím)
- Hiển thị ra màn hình thông tin về các cá nhân hiện đang trọ ở khách sạn đó.
- Tìm kiếm thông tin về những khách thuê phòng theo họ và tên.
- Tính tiền cho khách hàng khi thanh toán trả phòng
- Thoát khỏi chương trình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyKhachSan quanLyKhachSan = new QuanLyKhachSan();
        quanLyKhachSan.NhapThongTinKhach();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Hiển thị thông tin tất cả khách trọ");
            Console.WriteLine("2. Tìm kiếm khách theo họ tên");
            Console.WriteLine("3. Tính tiền thanh toán cho khách");
            Console.WriteLine("4. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    quanLyKhachSan.HienThiDanhSachKhach();
                    break;

                case 2:
                    Console.Write("Nhập họ tên để tìm kiếm: ");
                    string hoTenSearch = Console.ReadLine();
                    quanLyKhachSan.TimKiemKhachTheoHoTen(hoTenSearch);
                    break;

                case 3:
                    Console.Write("Nhập họ tên khách để tính tiền: ");
                    string hoTenThanhToan = Console.ReadLine();
                    quanLyKhachSan.TinhTienThanhToanCuaKhach(hoTenThanhToan);
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
