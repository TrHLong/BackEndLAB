// QuanLyHoDan.cs
using System;
using System.Collections.Generic;

public class QuanLyHoDan
{
    public List<KhuPho> KhuPhoList { get; set; }

    public QuanLyHoDan()
    {
        KhuPhoList = new List<KhuPho>();
    }

    public void NhapThongTinHoDan()
    {
        Console.WriteLine("Nhập số lượng hộ dân:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho hộ gia đình thứ {i + 1}:");
            Console.Write("Nhập số nhà: ");
            string soNha = Console.ReadLine();

            KhuPho khuPho = new KhuPho(soNha);

            Console.WriteLine("Nhập số lượng thành viên trong hộ:");
            int soThanhVien = int.Parse(Console.ReadLine());

            for (int j = 0; j < soThanhVien; j++)
            {
                Console.WriteLine($"\nNhập thông tin cho thành viên thứ {j + 1}:");
                Console.Write("Số CMND: ");
                string soCMND = Console.ReadLine();
                Console.Write("Họ tên: ");
                string hoTen = Console.ReadLine();
                Console.Write("Tuổi: ");
                int tuoi = int.Parse(Console.ReadLine());
                Console.Write("Năm sinh: ");
                int namSinh = int.Parse(Console.ReadLine());
                Console.Write("Nghề nghiệp: ");
                string ngheNghiep = Console.ReadLine();

                Nguoi nguoi = new Nguoi(soCMND, hoTen, tuoi, namSinh, ngheNghiep);
                khuPho.ThemNguoi(nguoi);
            }

            KhuPhoList.Add(khuPho);
        }
    }

    public void TimKiemTheoHoTen(string hoTen)
    {
        bool foundByName = false;
        foreach (var khuPho in KhuPhoList)
        {
            var nguoi = khuPho.TimKiemTheoHoTen(hoTen);
            if (nguoi != null)
            {
                nguoi.HienThi();
                foundByName = true;
                break;
            }
        }
        if (!foundByName)
        {
            Console.WriteLine("Không tìm thấy người với họ tên này.");
        }
    }

    public void TimKiemTheoSoNha(string soNha)
    {
        bool foundBySoNha = false;
        foreach (var khuPho in KhuPhoList)
        {
            var nguoi = khuPho.TimKiemTheoSoNha(soNha);
            if (nguoi != null)
            {
                khuPho.HienThi();
                foundBySoNha = true;
                break;
            }
        }
        if (!foundBySoNha)
        {
            Console.WriteLine("Không tìm thấy hộ gia đình với số nhà này.");
        }
    }

    public void HienThiToanBoThongTin()
    {
        Console.WriteLine("\nThông tin tất cả các hộ gia đình:");
        foreach (var khuPho in KhuPhoList)
        {
            khuPho.HienThi();
        }
    }
}
