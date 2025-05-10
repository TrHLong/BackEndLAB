// QuanLyMuonSach.cs
using System;
using System.Collections.Generic;

public class QuanLyMuonSach
{
    public List<TheMuon> DanhSachTheMuon { get; set; }

    public QuanLyMuonSach()
    {
        DanhSachTheMuon = new List<TheMuon>();
    }

    public void NhapThongTinMuonSach()
    {
        Console.WriteLine("Nhập số lượng sinh viên mượn sách:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho sinh viên thứ {i + 1}:");

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.Write("Lớp: ");
            string lop = Console.ReadLine();

            Console.Write("Mã số sinh viên: ");
            string maSoSinhVien = Console.ReadLine();

            SinhVien sinhVien = new SinhVien(hoTen, namSinh, lop, maSoSinhVien);

            Console.Write("Số phiếu mượn: ");
            string soPhieuMuon = Console.ReadLine();

            Console.Write("Ngày mượn (dd/MM/yyyy): ");
            DateTime ngayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Hạn trả (dd/MM/yyyy): ");
            DateTime hanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Số hiệu sách: ");
            string soHieuSach = Console.ReadLine();

            TheMuon theMuon = new TheMuon(soPhieuMuon, ngayMuon, hanTra, soHieuSach, sinhVien);
            DanhSachTheMuon.Add(theMuon);
        }
    }

    public void TimKiemSinhVienTheoMaSo(string maSoSinhVien)
    {
        bool found = false;
        foreach (var theMuon in DanhSachTheMuon)
        {
            if (theMuon.TimKiemTheoMaSoSinhVien(maSoSinhVien))
            {
                theMuon.HienThiThongTin();
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã số này.");
        }
    }

    public void HienThiSinhVienDenHan(DateTime currentDate)
    {
        Console.WriteLine("\nDanh sách sinh viên đã đến hạn trả sách:");
        foreach (var theMuon in DanhSachTheMuon)
        {
            if (theMuon.DaDenHan(currentDate))
            {
                theMuon.HienThiThongTin();
            }
        }
    }
}
