/* Bài 18:
1.Thông tin về mỗi cá nhân bao gồm : Họ tên, giới tính, tuổi. Hãy xây dựng lớp Nguoi chứa
các đối tượng là các cá nhân và xây dựng các phương thức:
-Các toán tử tạo lập: Nguoi(); Nguoi(String, boolean, int);
-Phương thức in() để in thông tin về một cá nhân
2. Hãy xây dựng lớp CoQuan chứa thông tin về các cá nhân trong một đơn vị được dẫn xuất
từ lớp Nguoi và có thêm các thành phần:
-Thuộc tính kiểu String xác định đơn vị công tác (bộ môn, phòng), thuộc tính kiểu double xác
định hệ số lương.
- Viết đè phương thức in() ở lớp Nguoi để in thông tin về một cá nhân trong CoQuan
- Cài đặt phương thức tinhLuong(CoQuan) để tính lương cho mỗi cá nhân trong cơ quan.
Lương =hệ số lương x Lương cơ bản;
Trong đó lương cơ bản là một hằng số được quy định bởi nhà nước (Lương cơ bản ở thời điểm
hiện tại đang là 1.050.000 vnđ).
3. Nhập vào một danh sách các cá nhân thuộc vào lớp CoQuan:
-Hiển thị thông tin cho cá nhân có đơn vị là Phòng tài chính;
-Tìm kiếm thông tin theo họ tên;
-Thoát khỏi chương trình. */


using System;
using System.Collections.Generic;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<CoQuan> danhSachCoQuan = new List<CoQuan>();
        bool isRunning = true;

        while (isRunning)
        {
            // Menu các chức năng
            Console.WriteLine("\nChọn một chức năng:");
            Console.WriteLine("1. Nhập thông tin cá nhân");
            Console.WriteLine("2. Hiển thị thông tin cá nhân trong phòng tài chính");
            Console.WriteLine("3. Tìm kiếm thông tin theo họ tên");
            Console.WriteLine("4. Thoát chương trình");
            Console.Write("Lựa chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Nhập thông tin các cá nhân
                    Console.Write("Nhập họ tên: ");
                    string hoTen = Console.ReadLine();
                    Console.Write("Nhập giới tính (true: Nam, false: Nữ): ");
                    bool gioiTinh = bool.Parse(Console.ReadLine());
                    Console.Write("Nhập tuổi: ");
                    int tuoi = int.Parse(Console.ReadLine());
                    Console.Write("Nhập đơn vị công tác: ");
                    string donViCongTac = Console.ReadLine();
                    Console.Write("Nhập hệ số lương: ");
                    double heSoLuong = double.Parse(Console.ReadLine());

                    CoQuan coQuan = new CoQuan(hoTen, gioiTinh, tuoi, donViCongTac, heSoLuong);
                    danhSachCoQuan.Add(coQuan);
                    break;

                case 2:
                    // Hiển thị thông tin cá nhân trong phòng tài chính
                    Console.WriteLine("\nDanh sách các cá nhân trong phòng tài chính:");
                    foreach (var coQuanItem in danhSachCoQuan)
                    {
                        if (coQuanItem.DonViCongTac.ToLower() == "phòng tài chính")
                        {
                            coQuanItem.In();
                            Console.WriteLine($"Lương: {coQuanItem.TinhLuong():0.00} VND");
                        }
                    }
                    break;

                case 3:
                    // Tìm kiếm theo họ tên
                    Console.Write("Nhập họ tên cần tìm: ");
                    string tenTimKiem = Console.ReadLine();
                    bool found = false;
                    foreach (var coQuanItem in danhSachCoQuan)
                    {
                        if (coQuanItem.HoTen.ToLower() == tenTimKiem.ToLower())
                        {
                            coQuanItem.In();
                            Console.WriteLine($"Lương: {coQuanItem.TinhLuong():0.00} VND");
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Không tìm thấy cá nhân với tên này.");
                    }
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
