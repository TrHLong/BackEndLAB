// PhanSo.cs
using System;

public class PhanSo
{
    public int TuSo { get; set; }
    public int MauSo { get; set; }

    // Hàm tạo không có đối số
    public PhanSo()
    {
        TuSo = 0;
        MauSo = 1; // Mẫu số mặc định là 1 (để tránh chia cho 0)
    }

    // Hàm tạo có đối số
    public PhanSo(int tu, int mau)
    {
        TuSo = tu;
        MauSo = mau;
        if (MauSo == 0)
        {
            Console.WriteLine("Mẫu số không thể là 0. Mẫu số đã được đặt lại là 1.");
            MauSo = 1;
        }
    }

    // Phương thức nhập phân số
    public void NhapPhanSo()
    {
        Console.Write("Nhập tử số: ");
        TuSo = int.Parse(Console.ReadLine());
        Console.Write("Nhập mẫu số: ");
        MauSo = int.Parse(Console.ReadLine());
        if (MauSo == 0)
        {
            Console.WriteLine("Mẫu số không thể là 0. Mẫu số đã được đặt lại là 1.");
            MauSo = 1;
        }
    }

    // Phương thức hiển thị phân số
    public void HienThiPhanSo()
    {
        Console.WriteLine($"{TuSo}/{MauSo}");
    }

    // Phương thức rút gọn phân số
    public void RutGonPhanSo()
    {
        int gcd = GCD(TuSo, MauSo); // Tìm UCLN của tử số và mẫu số
        TuSo /= gcd;
        MauSo /= gcd;
    }

    // Phương thức tính UCLN của hai số
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Phương thức cộng hai phân số
    public PhanSo Cộng(PhanSo ps)
    {
        int tuSo = this.TuSo * ps.MauSo + ps.TuSo * this.MauSo;
        int mauSo = this.MauSo * ps.MauSo;
        PhanSo result = new PhanSo(tuSo, mauSo);
        result.RutGonPhanSo();
        return result;
    }

    // Phương thức trừ hai phân số
    public PhanSo Tru(PhanSo ps)
    {
        int tuSo = this.TuSo * ps.MauSo - ps.TuSo * this.MauSo;
        int mauSo = this.MauSo * ps.MauSo;
        PhanSo result = new PhanSo(tuSo, mauSo);
        result.RutGonPhanSo();
        return result;
    }

    // Phương thức nhân hai phân số
    public PhanSo Nhan(PhanSo ps)
    {
        int tuSo = this.TuSo * ps.TuSo;
        int mauSo = this.MauSo * ps.MauSo;
        PhanSo result = new PhanSo(tuSo, mauSo);
        result.RutGonPhanSo();
        return result;
    }

    // Phương thức chia hai phân số
    public PhanSo Chia(PhanSo ps)
    {
        if (ps.TuSo == 0)
        {
            Console.WriteLine("Không thể chia cho phân số có tử số bằng 0.");
            return new PhanSo();
        }
        int tuSo = this.TuSo * ps.MauSo;
        int mauSo = this.MauSo * ps.TuSo;
        PhanSo result = new PhanSo(tuSo, mauSo);
        result.RutGonPhanSo();
        return result;
    }
}
