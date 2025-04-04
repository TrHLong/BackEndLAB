/* Bài 3: Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, thí sinh thi khối B, thí sinh
thi khối C
+ Các thí sinh cần quản lý các thuộc tính: Số báo danh, họ tên, địa chỉ, ưu tiên.
+ Thí sinh thi khối A thi các môn: Toán, lý, hoá
+ Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh
+ Thí sinh thi khối C thi các môn: Văn, Sử, Địa
1. Xây dựng các lớp để quản lý các thí sinh sao cho sử dụng lại được nhiều nhất.
2. Xây dựng lớp TuyenSinh cài đặt các phương thức thực hiện các nhiệm vụ sau:
-Nhập thông tin về các thí sinh dự thi
- Hiển thị thông tin về các thí sinh đã trúng tuyển (Giả sử điểm chuẩn cho khối A: 15,
điểm chuẩn khối B: 16, điểm chuẩn khối C: 13,5).
-Tìm kiếm các thí sinh theo số báo danh
- Kết thúc chương trình. */

using System;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        TuyenSinh tuyenSinh = new TuyenSinh();
        int luaChon;
        do
        {
            Console.WriteLine("1. Nhập thông tin thí sinh");
            Console.WriteLine("2. Hiển thị danh sách thí sinh");
            Console.WriteLine("3. Tìm kiếm thí sinh theo số báo danh");
            Console.WriteLine("4. Xem các thí sinh trúng tuyển");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine());

            switch (luaChon)
            {
                case 1:
                    tuyenSinh.NhapThongTin();
                    break;

                case 2:
                    tuyenSinh.HienThiDanhSach();
                    break;

                case 3:
                    Console.Write("Nhập số báo danh cần tìm: ");
                    string soBaoDanh = Console.ReadLine();
                    tuyenSinh.TimKiemTheoSBD(soBaoDanh);
                    break;

                case 4:
                    tuyenSinh.XemTrungTuyen();
                    break;

                case 5:
                    Console.WriteLine("Thoát khỏi chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (luaChon != 5);
    }
}
