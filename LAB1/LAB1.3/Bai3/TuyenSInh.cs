using System;
using System.Collections.Generic;

public class TuyenSinh
{
    private List<ThiSinh> danhSachThiSinh;

    public TuyenSinh()
    {
        danhSachThiSinh = new List<ThiSinh>();
    }

    public void NhapThongTin()
    {
        Console.WriteLine("Nhập thông tin thí sinh:");
        Console.WriteLine("1. Khối A");
        Console.WriteLine("2. Khối B");
        Console.WriteLine("3. Khối C");
        Console.Write("Chọn loại thí sinh (1/2/3): ");
        int luaChon = int.Parse(Console.ReadLine());

        Console.Write("Nhập số báo danh: ");
        string soBaoDanh = Console.ReadLine();
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        string diaChi = Console.ReadLine();
        Console.Write("Nhập ưu tiên: ");
        int uuTien = int.Parse(Console.ReadLine());

        switch (luaChon)
        {
            case 1: // Khối A
                Console.Write("Nhập điểm Toán: ");
                double diemToanA = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Lý: ");
                double diemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Hóa: ");
                double diemHoa = double.Parse(Console.ReadLine());
                danhSachThiSinh.Add(new ThiSinhKhoiA(soBaoDanh, hoTen, diaChi, uuTien, diemToanA, diemLy, diemHoa));
                break;

            case 2: // Khối B
                Console.Write("Nhập điểm Toán: ");
                double diemToanB = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Hóa: ");
                double diemHoaB = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Sinh: ");
                double diemSinh = double.Parse(Console.ReadLine());
                danhSachThiSinh.Add(new ThiSinhKhoiB(soBaoDanh, hoTen, diaChi, uuTien, diemToanB, diemHoaB, diemSinh));
                break;

            case 3: // Khối C
                Console.Write("Nhập điểm Văn: ");
                double diemVan = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Sử: ");
                double diemSu = double.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Địa: ");
                double diemDia = double.Parse(Console.ReadLine());
                danhSachThiSinh.Add(new ThiSinhKhoiC(soBaoDanh, hoTen, diaChi, uuTien, diemVan, diemSu, diemDia));
                break;

            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    public void HienThiDanhSach()
    {
        Console.WriteLine("Danh sách các thí sinh:");
        foreach (var thiSinh in danhSachThiSinh)
        {
            thiSinh.HienThi();
            Console.WriteLine();
        }
    }

    public void TimKiemTheoSBD(string soBaoDanh)
    {
        Console.WriteLine($"Kết quả tìm kiếm thí sinh với số báo danh {soBaoDanh}:");
        foreach (var thiSinh in danhSachThiSinh)
        {
            if (thiSinh.SoBaoDanh == soBaoDanh)
            {
                thiSinh.HienThi();
                return;
            }
        }
        Console.WriteLine("Không tìm thấy thí sinh!");
    }

    public void XemTrungTuyen()
    {
        Console.WriteLine("Danh sách thí sinh trúng tuyển:");
        foreach (var thiSinh in danhSachThiSinh)
        {
            double diemTong = 0;
            if (thiSinh is ThiSinhKhoiA)
                diemTong = ((ThiSinhKhoiA)thiSinh).TinhDiemTong();
            else if (thiSinh is ThiSinhKhoiB)
                diemTong = ((ThiSinhKhoiB)thiSinh).TinhDiemTong();
            else if (thiSinh is ThiSinhKhoiC)
                diemTong = ((ThiSinhKhoiC)thiSinh).TinhDiemTong();

            double diemChuan = 0;
            if (thiSinh is ThiSinhKhoiA)
                diemChuan = 15;
            else if (thiSinh is ThiSinhKhoiB)
                diemChuan = 16;
            else if (thiSinh is ThiSinhKhoiC)
                diemChuan = 13.5;

            if (diemTong >= diemChuan)
                thiSinh.HienThi();
        }
    }
}
