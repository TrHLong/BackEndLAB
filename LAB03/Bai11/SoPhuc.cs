// SoPhuc.cs
using System;

public class SoPhuc
{
    public double PhanThuc { get; set; }
    public double PhanAo { get; set; }

    // Hàm tạo không có đối số
    public SoPhuc()
    {
        PhanThuc = 0;
        PhanAo = 0;
    }

    // Hàm tạo có đối số
    public SoPhuc(double a, double b)
    {
        PhanThuc = a;
        PhanAo = b;
    }

    // Phương thức nhập số phức
    public void NhapSoPhuc()
    {
        Console.Write("Nhập phần thực: ");
        PhanThuc = double.Parse(Console.ReadLine());

        Console.Write("Nhập phần ảo: ");
        PhanAo = double.Parse(Console.ReadLine());
    }

    // Phương thức hiển thị số phức
    public void HienThiSoPhuc()
    {
        if (PhanAo >= 0)
            Console.WriteLine($"{PhanThuc} + {PhanAo}i");
        else
            Console.WriteLine($"{PhanThuc} - {Math.Abs(PhanAo)}i");
    }

    // Phương thức cộng hai số phức
    public SoPhuc Cộng(SoPhuc b)
    {
        double aThuc = this.PhanThuc + b.PhanThuc;
        double aAo = this.PhanAo + b.PhanAo;
        return new SoPhuc(aThuc, aAo);
    }

    // Phương thức nhân hai số phức
    public SoPhuc Nhan(SoPhuc b)
    {
        double aThuc = this.PhanThuc * b.PhanThuc - this.PhanAo * b.PhanAo;
        double aAo = this.PhanThuc * b.PhanAo + this.PhanAo * b.PhanThuc;
        return new SoPhuc(aThuc, aAo);
    }

    // Phương thức chia hai số phức
    public SoPhuc Chia(SoPhuc b)
    {
        double denominator = b.PhanThuc * b.PhanThuc + b.PhanAo * b.PhanAo;
        if (denominator == 0)
        {
            Console.WriteLine("Không thể chia cho số phức có mẫu bằng 0.");
            return new SoPhuc(0, 0); // Trả về số phức 0 nếu chia cho 0
        }

        double aThuc = (this.PhanThuc * b.PhanThuc + this.PhanAo * b.PhanAo) / denominator;
        double aAo = (this.PhanAo * b.PhanThuc - this.PhanThuc * b.PhanAo) / denominator;
        return new SoPhuc(aThuc, aAo);
    }
}
