// QLCB.cs
using System;
using System.Collections.Generic;
using LAB03.Common;

public class QLCB
{
    private List<CanBo> danhSachCanBo;

    public QLCB()
    {
        danhSachCanBo = new List<CanBo>();
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhập thông tin cán bộ:");
        Console.WriteLine("1. Công nhân");
        Console.WriteLine("2. Kỹ sư");
        Console.WriteLine("3. Nhân viên");
        Console.Write("Chọn loại cán bộ (1/2/3): ");
        int luaChon = int.Parse(Console.ReadLine()!);

        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine()!;
        Console.Write("Nhập năm sinh: ");
        int namSinh = int.Parse(Console.ReadLine()!);
        Console.Write("Nhập giới tính: ");
        string gioiTinh = Console.ReadLine()!;
        Console.Write("Nhập địa chỉ: ");
        string diaChi = Console.ReadLine()!;

        switch (luaChon)
        {
            case 1: // Công nhân
                Console.Write("Nhập bậc công nhân: ");
                string bac = Console.ReadLine()!;
                danhSachCanBo.Add(new CongNhan(hoTen, namSinh, gioiTinh, diaChi, bac));
                break;

            case 2: // Kỹ sư
                Console.Write("Nhập ngành đào tạo: ");
                string nganhDaoTao = Console.ReadLine()!;
                danhSachCanBo.Add(new KySu(hoTen, namSinh, gioiTinh, diaChi, nganhDaoTao));
                break;

            case 3: // Nhân viên
                Console.Write("Nhập công việc: ");
                string congViec = Console.ReadLine()!;
                danhSachCanBo.Add(new NhanVien(hoTen, namSinh, gioiTinh, diaChi, congViec));
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    public void TimKiemTheoTen(string ten)
    {
        Console.WriteLine($"Kết quả tìm kiếm cán bộ có tên {ten}:");
        foreach (var canBo in danhSachCanBo)
        {
            if (canBo.HoTen.Contains(ten))
            {
                canBo.HienThi();
                Console.WriteLine();
            }
        }
    }

    public void HienThiDanhSach()
    {
        GlobalConfig.SetupConsole();
        Console.WriteLine("Danh sách cán bộ:");
        foreach (var canBo in danhSachCanBo)
        {
            canBo.HienThi();
            Console.WriteLine();
        }
    }
}
