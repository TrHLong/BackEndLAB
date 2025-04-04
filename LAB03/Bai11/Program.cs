/* Bài 11: Xây dựng lớp SoPhuc có các thuộc tính riêng gồm: phanThuc, phanAo kiểu double
1. Xây dựng các hàm tạo như sau: SoPhuc(), SoPhuc(double a, double b)
2.Xây dựng các phương thức:
+Nhập vào một số phức
+ Hiển thị một số phức
+ Cộng hai số phức.
+ Nhân hai số phức
+ Chia hai số phức.
3. Cài đặt chương trình thực hiện : Nhập vào hai số phức A và B, sau đó hỏi người dùng muốn
thực hiện tác vụ nào:
a) Tính tổng hai số phức;
b) Tính hiệu hai số phức;
c) Tính tích hai số phức;
d) Tính thương hai số phức;
Rồi hiển thị kết quả ra màn hình */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        SoPhuc A = new SoPhuc();
        SoPhuc B = new SoPhuc();

        // Nhập vào hai số phức A và B
        Console.WriteLine("Nhập số phức A:");
        A.NhapSoPhuc();
        Console.WriteLine("Nhập số phức B:");
        B.NhapSoPhuc();

        bool isRunning = true;
        while (isRunning)
        {
            // Menu các phép toán
            Console.WriteLine("\nChọn một phép toán:");
            Console.WriteLine("1. Tính tổng hai số phức");
            Console.WriteLine("2. Tính hiệu hai số phức");
            Console.WriteLine("3. Tính tích hai số phức");
            Console.WriteLine("4. Tính thương hai số phức");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SoPhuc tong = A.Cộng(B);
                    Console.WriteLine("Tổng hai số phức A và B: ");
                    tong.HienThiSoPhuc();
                    break;

                case 2:
                    SoPhuc hieu = A.Cộng(new SoPhuc(-B.PhanThuc, -B.PhanAo)); // Tính hiệu = A + (-B)
                    Console.WriteLine("Hiệu hai số phức A và B: ");
                    hieu.HienThiSoPhuc();
                    break;

                case 3:
                    SoPhuc tich = A.Nhan(B);
                    Console.WriteLine("Tích hai số phức A và B: ");
                    tich.HienThiSoPhuc();
                    break;

                case 4:
                    SoPhuc thuong = A.Chia(B);
                    Console.WriteLine("Thương của hai số phức A và B: ");
                    thuong.HienThiSoPhuc();
                    break;

                case 5:
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
