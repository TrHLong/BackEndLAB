/* Bài 2: Một thư viện cần quản lý các tài liệu bao gồm, Sách, Tạp chí, Báo
+ Mỗi tài liệu có các thuộc tính: Mã tài liệu, Tên nhà xuất bản, Số bản phát hành.
+ Các loại sách cần quản lý: Tên tác giả, số trang
+ Các tạp chí cần quản lý: Số phát hành, tháng phát hành
+ Các báo cần quản lý: ngày phát hành.
1. Xây dựng các lớp để quản lý các loại tài liệu trên sao cho việc sử dụng lại được nhiều nhất.
2. Xây dựng lớp QuanLyTailieu cài đặt các phương thức thực hiện các công việc sau:
-Nhập thông tin về các tài liệu (Hỏi người dùng muốn nhập thông tin cho loại tài liệu
nào: Sách, Tạp chí hay Báo và nhập đúng thông tin cho loại tài liệu đó).
- Hiển thị thông tin về các tài liệu
- Tìm kiếm tài liệu theo loại
- Thoát khỏi chương trình */

using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyTailieu quanLy = new QuanLyTailieu();
        int luaChon;

        do
        {
            Console.WriteLine("1. Nhập thông tin tài liệu");
            Console.WriteLine("2. Hiển thị danh sách tài liệu");
            Console.WriteLine("3. Tìm kiếm tài liệu theo loại");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine()!);

            switch (luaChon)
            {
                case 1:
                    quanLy.NhapThongTin();
                    break;

                case 2:
                    quanLy.HienThiDanhSach();
                    break;

                case 3:
                    quanLy.TimKiemTheoLoai();
                    break;

                case 4:
                    Console.WriteLine("Thoát khỏi chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (luaChon != 4);
    }
}
