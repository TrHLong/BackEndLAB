// QuanLyKhachSan.cs
using System;
using System.Collections.Generic;

public class QuanLyKhachSan
{
    public List<KhachSan> DanhSachKhach { get; set; }

    public QuanLyKhachSan()
    {
        DanhSachKhach = new List<KhachSan>();
    }

    public void NhapThongTinKhach()
    {
        Console.WriteLine("Nhập số lượng khách trọ:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho khách trọ thứ {i + 1}:");

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();

            Nguoi khach = new Nguoi(hoTen, namSinh, soCMND);

            Console.Write("Loại phòng: ");
            string loaiPhong = Console.ReadLine();

            Console.Write("Giá phòng (VND/ngày): ");
            double giaPhong = double.Parse(Console.ReadLine());

            Console.Write("Số ngày trọ: ");
            int soNgayTro = int.Parse(Console.ReadLine());

            KhachSan khachSan = new KhachSan(loaiPhong, giaPhong, soNgayTro, khach);
            DanhSachKhach.Add(khachSan);
        }
    }

    public void HienThiDanhSachKhach()
    {
        Console.WriteLine("\nDanh sách các khách trọ:");
        foreach (var khach in DanhSachKhach)
        {
            khach.HienThiThongTin();
            Console.WriteLine($"Tiền thanh toán: {khach.TinhTienThanhToan()} VND");
        }
    }

    public void TimKiemKhachTheoHoTen(string hoTen)
    {
        bool found = false;
        foreach (var khach in DanhSachKhach)
        {
            if (khach.TimKiemTheoHoTen(hoTen))
            {
                khach.HienThiThongTin();
                Console.WriteLine($"Tiền thanh toán: {khach.TinhTienThanhToan()} VND");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Không tìm thấy khách trọ với họ tên này.");
        }
    }

    public void TinhTienThanhToanCuaKhach(string hoTen)
    {
        bool found = false;
        foreach (var khach in DanhSachKhach)
        {
            if (khach.TimKiemTheoHoTen(hoTen))
            {
                Console.WriteLine($"Tiền thanh toán của khách {hoTen}: {khach.TinhTienThanhToan()} VND");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Không tìm thấy khách trọ với họ tên này.");
        }
    }
}
