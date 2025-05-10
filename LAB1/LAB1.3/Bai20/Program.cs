/* Bài 20: Một hội quản lý hội viên của mình như sau: Mỗi hội viên có hai thông tin chung là họ
tên, địa chỉ. Ai đã có gia đình thì khai thêm họ tên vợ và ngày cưới. Ai đã có người yêu thì
khai thêm họ tên và số điện thoại của người yêu. Ai chưa có người yêu thì không khai thêm gì
cả.
1. Hãy xây dựng các lớp sao cho việc kế thừa được sử dụng lại nhiều nhất.
2. Nhập danh sách cho N hội viên (N nhập vào từ bàn phím)
3. Tìm kiếm thông tin của những hội viên có ngày cưới là: 11.11.2011.
4.Hiển thị thông tin cho những người đã có người yêu nhưng chưa lập gia đình. */


using System;
using System.Collections.Generic;
using LAB03.Common;
class Program
{
    static void Main(string[] args)
    {
        GlobalConfig.SetupConsole();
        List<HoiVien> danhSachHoiVien = new List<HoiVien>();
        Console.Write("Nhập số lượng hội viên: ");
        int n = int.Parse(Console.ReadLine());

        // Nhập thông tin cho n hội viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho hội viên thứ {i + 1}:");

            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string diaChi = Console.ReadLine();

            Console.WriteLine("1. Đã có gia đình");
            Console.WriteLine("2. Có người yêu");
            Console.WriteLine("3. Chưa có người yêu");
            Console.Write("Chọn trạng thái: ");
            int trangThai = int.Parse(Console.ReadLine());

            if (trangThai == 1)
            {
                Console.Write("Nhập họ tên vợ/chồng: ");
                string voChong = Console.ReadLine();
                Console.Write("Nhập ngày cưới (dd/MM/yyyy): ");
                DateTime ngayCuoi = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                DaCoGiaDinh daCoGiaDinh = new DaCoGiaDinh(hoTen, diaChi, voChong, ngayCuoi);
                danhSachHoiVien.Add(daCoGiaDinh);
            }
            else if (trangThai == 2)
            {
                Console.Write("Nhập tên người yêu: ");
                string nguoiYeu = Console.ReadLine();
                Console.Write("Nhập số điện thoại người yêu: ");
                string soDienThoai = Console.ReadLine();

                DaCoNguoiYeu daCoNguoiYeu = new DaCoNguoiYeu(hoTen, diaChi, nguoiYeu, soDienThoai);
                danhSachHoiVien.Add(daCoNguoiYeu);
            }
            else
            {
                HoiVien hoiVien = new HoiVien(hoTen, diaChi);
                danhSachHoiVien.Add(hoiVien);
            }
        }

        // Tìm kiếm các hội viên có ngày cưới là 11.11.2011
        Console.WriteLine("\nDanh sách các hội viên có ngày cưới là 11/11/2011:");
        foreach (var hoiVien in danhSachHoiVien)
        {
            if (hoiVien is DaCoGiaDinh && ((DaCoGiaDinh)hoiVien).NgayCuoi == new DateTime(2011, 11, 11))
            {
                hoiVien.InThongTin();
            }
        }

        // Hiển thị thông tin cho những người đã có người yêu nhưng chưa lập gia đình
        Console.WriteLine("\nDanh sách những người đã có người yêu nhưng chưa lập gia đình:");
        foreach (var hoiVien in danhSachHoiVien)
        {
            if (hoiVien is DaCoNguoiYeu)
            {
                hoiVien.InThongTin();
            }
        }
    }
}
