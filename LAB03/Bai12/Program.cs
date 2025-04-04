/* Bài 12: Xây dựng lớp MaTran có các thuộc tính riêng như sau:
+Số dòng, số cột của ma trận
+ Một mảng hai chiều để lưu trữ các phần tử của ma trận Hãy:
1.Xây dựng các hàm tạo : MaTran(), maTran(int n, int m); (Toán tử tạo lập thứ hai để tạo ra
ma trận có n dòng và m cột)
2. Xây dựng các phương thức: Nhập vào và hiển thị một ma trận
3. Xây dựng các phương thức tính tổng, hiệu và tích, thương của hai ma trận
4. Cài đặt chương trình thực hiện : Nhập vào hai ma trận A và B cùng cấp, sau đó hỏi người
dùng muốn thực hiện tác vụ nào:
a) Tính tổng hai ma trận;
b) Tính tích hai ma trận;
c) Tính hiệu hai ma trận;
d) Tính thương hai ma trận 
Hiển thị kết quả ra màn hình. */

using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        // Nhập hai ma trận A và B
        Console.WriteLine("Nhập số dòng và số cột của ma trận A:");
        int nA = int.Parse(Console.ReadLine());
        int mA = int.Parse(Console.ReadLine());

        MaTran A = new MaTran(nA, mA);
        A.NhapMaTran();

        Console.WriteLine("Nhập số dòng và số cột của ma trận B:");
        int nB = int.Parse(Console.ReadLine());
        int mB = int.Parse(Console.ReadLine());

        MaTran B = new MaTran(nB, mB);
        B.NhapMaTran();

        bool isRunning = true;
        while (isRunning)
        {
            // Menu các phép toán
            Console.WriteLine("\nChọn một phép toán:");
            Console.WriteLine("1. Tính tổng hai ma trận");
            Console.WriteLine("2. Tính hiệu hai ma trận");
            Console.WriteLine("3. Tính tích hai ma trận");
            Console.WriteLine("4. Tính thương hai ma trận");
            Console.WriteLine("5. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    MaTran tong = A.Cộng(B);
                    if (tong != null)
                    {
                        Console.WriteLine("Tổng của hai ma trận A và B là:");
                        tong.HienThiMaTran();
                    }
                    break;

                case 2:
                    MaTran hieu = A.Hieu(B);
                    if (hieu != null)
                    {
                        Console.WriteLine("Hiệu của hai ma trận A và B là:");
                        hieu.HienThiMaTran();
                    }
                    break;

                case 3:
                    MaTran tich = A.Nhan(B);
                    if (tich != null)
                    {
                        Console.WriteLine("Tích của hai ma trận A và B là:");
                        tich.HienThiMaTran();
                    }
                    break;

                case 4:
                    MaTran thuong = A.Chia(B);
                    if (thuong != null)
                    {
                        Console.WriteLine("Thương của hai ma trận A và B là:");
                        thuong.HienThiMaTran();
                    }
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
