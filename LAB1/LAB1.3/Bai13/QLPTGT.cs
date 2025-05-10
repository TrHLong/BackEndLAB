// QLPTGT.cs
using System;
using System.Collections.Generic;

public class QLPTGT
{
    public List<PTGT> DanhSachPTGT { get; set; }

    public QLPTGT()
    {
        DanhSachPTGT = new List<PTGT>();
    }

    public void NhapPhuongTien()
    {
        Console.WriteLine("Nhập loại phương tiện (1: Ô tô, 2: Xe máy, 3: Xe tải): ");
        int loaiPT = int.Parse(Console.ReadLine());

        Console.Write("Nhập hãng sản xuất: ");
        string hangSanXuat = Console.ReadLine();
        Console.Write("Nhập năm sản xuất: ");
        int namSanXuat = int.Parse(Console.ReadLine());
        Console.Write("Nhập giá bán: ");
        double giaBan = double.Parse(Console.ReadLine());
        Console.Write("Nhập màu: ");
        string mau = Console.ReadLine();

        switch (loaiPT)
        {
            case 1:
                Console.Write("Nhập số chỗ ngồi: ");
                int soChoNgoi = int.Parse(Console.ReadLine());
                Console.Write("Nhập kiểu động cơ: ");
                string kieuDongCo = Console.ReadLine();
                DanhSachPTGT.Add(new OTo(hangSanXuat, namSanXuat, giaBan, mau, soChoNgoi, kieuDongCo));
                break;
            case 2:
                Console.Write("Nhập công suất: ");
                double congSuat = double.Parse(Console.ReadLine());
                DanhSachPTGT.Add(new XeMay(hangSanXuat, namSanXuat, giaBan, mau, congSuat));
                break;
            case 3:
                Console.Write("Nhập trọng tải: ");
                double trongTai = double.Parse(Console.ReadLine());
                DanhSachPTGT.Add(new XeTai(hangSanXuat, namSanXuat, giaBan, mau, trongTai));
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    public void TimPhuongTien()
    {
        Console.WriteLine("Tìm theo (1: Màu, 2: Năm sản xuất): ");
        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.Write("Nhập màu muốn tìm: ");
            string mauTimKiem = Console.ReadLine();
            foreach (var pt in DanhSachPTGT)
            {
                if (pt.Mau.Equals(mauTimKiem, StringComparison.OrdinalIgnoreCase))
                {
                    pt.HienThi();
                }
            }
        }
        else if (option == 2)
        {
            Console.Write("Nhập năm sản xuất muốn tìm: ");
            int namTimKiem = int.Parse(Console.ReadLine());
            foreach (var pt in DanhSachPTGT)
            {
                if (pt.NamSanXuat == namTimKiem)
                {
                    pt.HienThi();
                }
            }
        }
        else
        {
            Console.WriteLine("Lựa chọn không hợp lệ!");
        }
    }
}
