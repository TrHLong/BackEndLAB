/* Bài 8: Thư viện của trường đại học Đại Nam có nhu cầu cần quản lý việc mượn sách. Sinh
viên đăng ký và tham gia mượn sách thông qua các thẻ mượn mà thư viện đã thiết kế.
- Với mỗi thẻ mượn, có các thông tin sau: số phiếu mượn, ngày mượn, hạn trả, số hiệu
sách, và các thông tin riêng về mỗi sinh viên đó.
- Các thông tin riêng về mỗi sinh viên đó bao gồm: Họ tên, năm sinh, lớp, mã số sinh
viên.
1. Hãy xây dựng lớp SinhVien để quản lý các thông tin riêng về mỗi sinh viên.
2. Xây dựng lớp TheMuon để quản lý việc mượn sách của mỗi độc giả.
3. Xây dựng các phương thức để nhập và hiện thị các thông tin riêng cho mỗi sinh viên .
4. Nhập vào một danh sách các sinh viên, sau đó thực hiện các công việc sau:
-Tìm kiếm thông tin về sinh viên theo mã số sinh viên;
-Hiển thị thông tin về các sinh viên đã đến hạn trả sách theo ngày hiện tại;
-Thoát khỏi chương trình. */



using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QuanLyMuonSach quanLyMuonSach = new QuanLyMuonSach();
        quanLyMuonSach.NhapThongTinMuonSach();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Tìm kiếm thông tin sinh viên theo mã số sinh viên");
            Console.WriteLine("2. Hiển thị thông tin các sinh viên đã đến hạn trả sách");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhập mã số sinh viên để tìm kiếm: ");
                    string maSoSinhVien = Console.ReadLine();
                    quanLyMuonSach.TimKiemSinhVienTheoMaSo(maSoSinhVien);
                    break;

                case 2:
                    Console.Write("Nhập ngày hiện tại (dd/MM/yyyy): ");
                    DateTime currentDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                    quanLyMuonSach.HienThiSinhVienDenHan(currentDate);
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
