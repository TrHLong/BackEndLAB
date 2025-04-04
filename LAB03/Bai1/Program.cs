/* Bài 1: Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên.
+ Mỗi cán bộ cần quản lý các thuộc tính: Họ tên, năm sinh, giới tính, địa chỉ
+ Các công nhân cần quản lý: Bậc(công nhân bậc 3 / 7, bậc 4 / 7...)
+ Các kỹ sư cần quản lý: Ngành đào tạo
+ Các nhân viên phục vụ cần quản lý thông tin: công việc
1. Xây dựng các lớp NhanVien, CongNhan, KySu kế thừa từ lớp CanBo
2. Xây dựng các phương thức nhập, hiển thị thông tin và kiểm tra về các thuộc tính của các
lớp.
3. Xây dựng lớp QLCB cài đặt các phương thức thực hiện các chức sau:
-Nhập thông tin mới cho cán bộ (Hỏi người dùng muốn nhập cho: công nhân, kỹ sư
hay nhân viên và nhập đúng thông tin cho đối tượng đó).
- Tìm kiếm theo họ tên
- Hiển thị thông tin về danh sách các cán bộ
- Thoát khỏi chương trình. */

using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        QLCB qlcb = new QLCB();
        int luaChon;
        do
        {
            Console.WriteLine("1. Nhập thông tin cán bộ");
            Console.WriteLine("2. Tìm kiếm cán bộ theo tên");
            Console.WriteLine("3. Hiển thị danh sách cán bộ");
            Console.WriteLine("4. Thoát");
            Console.Write("Chọn chức năng: ");
            luaChon = int.Parse(Console.ReadLine()!);

            switch (luaChon)
            {
                case 1:
                    qlcb.NhapThongTin();
                    break;

                case 2:
                    Console.Write("Nhập tên cán bộ cần tìm: ");
                    string ten = Console.ReadLine()!;
                    qlcb.TimKiemTheoTen(ten);
                    break;

                case 3:
                    qlcb.HienThiDanhSach();
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
