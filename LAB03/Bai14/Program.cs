/* Bài 14: Lớp PhanSo có các thuộc tính riêng gồm: tuSo, mauSo, Hãy:
1.Xây dựng các toán tử tạo lập : PhanSo(), PhanSo(int tu, int mau)
2.Xây dựng các phương thức:
+Nhập vào một phân số
+ Hiển thị một phân số
+ Rút gọn một phân số
+ Cộng hai phân số
+ Trừ hai phân số
+ Chia hai phân số
3. Cài đặt chương trình thực hiện: Nhập vào hai phân số A và B, sau đó tính thực hiện các yêu
cầu của người dùng rồi hiển thị kết quả ra màn hình. */


using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        // Khởi tạo hai phân số A và B
        PhanSo A = new PhanSo();
        PhanSo B = new PhanSo();

        // Nhập hai phân số A và B
        Console.WriteLine("Nhập phân số A:");
        A.NhapPhanSo();
        Console.WriteLine("Nhập phân số B:");
        B.NhapPhanSo();

        bool isRunning = true;
        while (isRunning)
        {
            // Hiển thị menu các phép toán
            Console.WriteLine("\nChọn một phép toán:");
            Console.WriteLine("1. Cộng hai phân số");
            Console.WriteLine("2. Trừ hai phân số");
            Console.WriteLine("3. Nhân hai phân số");
            Console.WriteLine("4. Chia hai phân số");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PhanSo tong = A.Cộng(B);
                    Console.WriteLine("Tổng của hai phân số A và B là:");
                    tong.HienThiPhanSo();
                    break;

                case 2:
                    PhanSo hieu = A.Tru(B);
                    Console.WriteLine("Hiệu của hai phân số A và B là:");
                    hieu.HienThiPhanSo();
                    break;

                case 3:
                    PhanSo tich = A.Nhan(B);
                    Console.WriteLine("Tích của hai phân số A và B là:");
                    tich.HienThiPhanSo();
                    break;

                case 4:
                    PhanSo thuong = A.Chia(B);
                    Console.WriteLine("Thương của hai phân số A và B là:");
                    thuong.HienThiPhanSo();
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
