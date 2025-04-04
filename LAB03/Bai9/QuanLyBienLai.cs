// QuanLyBienLai.cs
using System;
using System.Collections.Generic;

public class QuanLyBienLai
{
    public List<BienLai> DanhSachBienLai { get; set; }

    public QuanLyBienLai()
    {
        DanhSachBienLai = new List<BienLai>();
    }

    public void NhapThongTinBienLai(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho biên lai thứ {i + 1}:");

            Console.Write("Họ tên chủ hộ: ");
            string hoTen = Console.ReadLine();

            Console.Write("Số nhà: ");
            string soNha = Console.ReadLine();

            Console.Write("Mã số công tơ: ");
            string maSoCongTo = Console.ReadLine();

            Console.Write("Chỉ số cũ: ");
            int chiSoCu = int.Parse(Console.ReadLine());

            Console.Write("Chỉ số mới: ");
            int chiSoMoi = int.Parse(Console.ReadLine());

            KhachHang khachHang = new KhachHang(hoTen, soNha, maSoCongTo);
            BienLai bienLai = new BienLai(khachHang, chiSoCu, chiSoMoi);

            DanhSachBienLai.Add(bienLai);
        }
    }

    public void HienThiDanhSachBienLai()
    {
        Console.WriteLine("\nDanh sách biên lai đã nhập:");
        foreach (var bienLai in DanhSachBienLai)
        {
            bienLai.HienThiThongTin();
        }
    }

    public void HienThiBienLaiDenHan(DateTime currentDate)
    {
        Console.WriteLine("\nDanh sách các biên lai đã đến hạn thanh toán:");
        foreach (var bienLai in DanhSachBienLai)
        {
            if (bienLai.KhachHang.MaSoCongTo != null) // Giả sử đến hạn nếu có mã số công tơ
            {
                bienLai.HienThiThongTin();
            }
        }
    }
}
