using System;
using System.Collections.Generic;

public class QuanLyTailieu
{
    private List<TaiLieu> danhSachTaiLieu;

    public QuanLyTailieu()
    {
        danhSachTaiLieu = new List<TaiLieu>();
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhập thông tin tài liệu:");
        Console.WriteLine("1. Sách");
        Console.WriteLine("2. Tạp chí");
        Console.WriteLine("3. Báo");
        Console.Write("Chọn loại tài liệu (1/2/3): ");
        int luaChon = int.Parse(Console.ReadLine()!) !;

        Console.Write("Nhập mã tài liệu: ");
        string maTaiLieu = Console.ReadLine()  !;
        Console.Write("Nhập tên nhà xuất bản: ");
        string tenNhaXuatBan = Console.ReadLine() !;
        Console.Write("Nhập số bản phát hành: ");
        int soBanPhatHanh = int.Parse(Console.ReadLine()!);

        switch (luaChon)
        {
            case 1: // Sách
                Console.Write("Nhập tên tác giả: ");
                string tenTacGia = Console.ReadLine()!;
                Console.Write("Nhập số trang: ");
                int soTrang = int.Parse(Console.ReadLine()!);
                danhSachTaiLieu.Add(new Sach(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, tenTacGia, soTrang));
                break;

            case 2: // Tạp chí
                Console.Write("Nhập số phát hành: ");
                int soPhatHanh = int.Parse(Console.ReadLine()!);
                Console.Write("Nhập tháng phát hành: ");
                int thangPhatHanh = int.Parse(Console.ReadLine()!);
                danhSachTaiLieu.Add(new TapChi(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, soPhatHanh, thangPhatHanh));
                break;

            case 3: // Báo
                Console.Write("Nhập ngày phát hành (dd/MM/yyyy): ");
                DateTime ngayPhatHanh = DateTime.Parse(Console.ReadLine()!);
                danhSachTaiLieu.Add(new Bao(maTaiLieu, tenNhaXuatBan, soBanPhatHanh, ngayPhatHanh));
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách các tài liệu:");
        foreach (var taiLieu in danhSachTaiLieu)
        {
            taiLieu.HienThi();
            Console.WriteLine();
        }
    }

    public void TimKiemTheoLoai()
    {
        Console.Write("Nhập loại tài liệu cần tìm (Sách, Tạp chí, Báo): ");
        string loai = Console.ReadLine()!.ToLower();

        Console.WriteLine("Kết quả tìm kiếm:");
        foreach (var taiLieu in danhSachTaiLieu)
        {
            if (loai == "sách" && taiLieu is Sach)
            {
                taiLieu.HienThi();
            }
            else if (loai == "tạp chí" && taiLieu is TapChi)
            {
                taiLieu.HienThi();
            }
            else if (loai == "báo" && taiLieu is Bao)
            {
                taiLieu.HienThi();
            }
        }
    }
}
