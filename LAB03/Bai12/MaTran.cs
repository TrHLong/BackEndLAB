// MaTran.cs
using System;

public class MaTran
{
    public int SoDong { get; set; }
    public int SoCot { get; set; }
    public double[,] M { get; set; }

    // Hàm tạo không có đối số
    public MaTran()
    {
        SoDong = 0;
        SoCot = 0;
        M = null;
    }

    // Hàm tạo có đối số
    public MaTran(int n, int m)
    {
        SoDong = n;
        SoCot = m;
        M = new double[n, m];
    }

    // Phương thức nhập ma trận
    public void NhapMaTran()
    {
        Console.WriteLine($"Nhập ma trận có {SoDong} dòng và {SoCot} cột:");
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                Console.Write($"M[{i},{j}] = ");
                M[i, j] = double.Parse(Console.ReadLine());
            }
        }
    }

    // Phương thức hiển thị ma trận
    public void HienThiMaTran()
    {
        Console.WriteLine("Ma trận là:");
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                Console.Write(M[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Phương thức cộng hai ma trận
    public MaTran Cộng(MaTran B)
    {
        if (SoDong != B.SoDong || SoCot != B.SoCot)
        {
            Console.WriteLine("Không thể cộng hai ma trận có kích thước khác nhau!");
            return null;
        }

        MaTran C = new MaTran(SoDong, SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                C.M[i, j] = this.M[i, j] + B.M[i, j];
            }
        }
        return C;
    }

    // Phương thức hiệu của hai ma trận
    public MaTran Hieu(MaTran B)
    {
        if (SoDong != B.SoDong || SoCot != B.SoCot)
        {
            Console.WriteLine("Không thể trừ hai ma trận có kích thước khác nhau!");
            return null;
        }

        MaTran C = new MaTran(SoDong, SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < SoCot; j++)
            {
                C.M[i, j] = this.M[i, j] - B.M[i, j];
            }
        }
        return C;
    }

    // Phương thức nhân hai ma trận
    public MaTran Nhan(MaTran B)
    {
        if (SoCot != B.SoDong)
        {
            Console.WriteLine("Không thể nhân hai ma trận với kích thước này!");
            return null;
        }

        MaTran C = new MaTran(SoDong, B.SoCot);
        for (int i = 0; i < SoDong; i++)
        {
            for (int j = 0; j < B.SoCot; j++)
            {
                C.M[i, j] = 0;
                for (int k = 0; k < SoCot; k++)
                {
                    C.M[i, j] += this.M[i, k] * B.M[k, j];
                }
            }
        }
        return C;
    }

    // Phương thức chia hai ma trận (chia cho một ma trận đảo ngược)
    public MaTran Chia(MaTran B)
    {
        // Để chia ma trận, ta phải sử dụng ma trận đảo ngược của B
        // Thực tế, việc chia ma trận chỉ có thể thực hiện khi ma trận B là vuông và khả nghịch.
        // Để đơn giản, ta sẽ tính thương ma trận qua việc nhân với ma trận đảo ngược của B.
        Console.WriteLine("Phương thức chia không khả thi trong bài toán này!");
        return null;
    }
}
