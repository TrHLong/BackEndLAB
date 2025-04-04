// QuanLyCBGV.cs
using System;
using System.Collections.Generic;

public class QuanLyCBGV
{
    public List<CBGV> DanhSachCBGV { get; set; }

    public QuanLyCBGV()
    {
        DanhSachCBGV = new List<CBGV>();
    }

    public void NhapThongTinCBGV()
    {
        Console.WriteLine("Nhập số lượng cán bộ giáo viên:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin cho cán bộ giáo viên thứ {i + 1}:");

            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());

            Console.Write("Quê quán: ");
            string queQuan = Console.ReadLine();

            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();

            Nguoi canBo = new Nguoi(hoTen, namSinh, queQuan, soCMND);

            Console.Write("Lương cứng: ");
            double luongCung = double.Parse(Console.ReadLine());

            Console.Write("Thưởng: ");
            double thuong = double.Parse(Console.ReadLine());

            Console.Write("Phạt: ");
            double phat = double.Parse(Console.ReadLine());

            CBGV canBoGV = new CBGV(luongCung, thuong, phat, canBo);
            DanhSachCBGV.Add(canBoGV);
        }
    }

    public void TimKiemCBGVTheoQueQuan(string queQuan)
    {
        bool found = false;
        Console.WriteLine($"\nTìm kiếm cán bộ giáo viên theo quê quán: {queQuan}");
        foreach (var cb in DanhSachCBGV)
        {
            if (cb.TimKiemTheoQueQuan(queQuan))
            {
                cb.HienThiThongTin();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Không tìm thấy cán bộ giáo viên với quê quán này.");
        }
    }

    public void HienThiCBGVLuongTren5Trieu()
    {
        Console.WriteLine("\nDanh sách cán bộ giáo viên có lương thực lĩnh trên 5 triệu:");
        foreach (var cb in DanhSachCBGV)
        {
            if (cb.LươngThucLinhTren5Trieu())
            {
                cb.HienThiThongTin();
            }
        }
    }
}
