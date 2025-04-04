/* Bài 9: Để quản lý các biên lai thu tiền điện, người ta cần các thông tin như sau:
-Với mỗi biên lai, có các thông tin sau: thông tin về hộ sử dụng điện, chỉ số cũ, chỉ số
mới, số tiền phải trả của mỗi hộ sử dụng điện
- Các thông tin riêng của mỗi hộ sử dụng điện gồm: Họ tên chủ hộ, số nhà, mã số công
tơ của hộ dân sử dụng điện.
1. Hãy xây dựng lớp KhachHang để lưu trữ các thông tin riêng của mỗi hộ sử dụng điện.
2. Xây dựng lớp BienLai để quản lý việc sử dụng và thanh toán tiền điện của các hộ dân.
3. Xây dựng các phương thức nhập, và hiển thị thông tin riêng của mỗi hộ sử dụng điện.
4. Cài đặt chương trình thực hiện các công việc sau:
+Nhập vào các thông tin cho N hộ sử dụng điện
+ Hiển thị thông tin về các biên lai đã nhập
+ Tính tiền điện phải trả cho mỗi hộ dân, nếu giả sử rằng tiền phải trả được tính theo
công thức sau:
Số điện Giá tiền
Dưới 50 số 1250 vnđ/1 số
Từ 50 đến dưới 100 số 1500 vnđ/1 số
Từ 100 số trở lên 2000 vnđ/1 số */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyBienLai quanLyBienLai = new QuanLyBienLai();
        Console.Write("Nhập số lượng hộ sử dụng điện: ");
        int n = int.Parse(Console.ReadLine());
        quanLyBienLai.NhapThongTinBienLai(n);

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Hiển thị thông tin các biên lai đã nhập");
            Console.WriteLine("2. Tính tiền điện cho các hộ dân");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    quanLyBienLai.HienThiDanhSachBienLai();
                    break;

                case 2:
                    Console.WriteLine("\nDanh sách biên lai thanh toán tiền điện:");
                    quanLyBienLai.HienThiDanhSachBienLai();
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
