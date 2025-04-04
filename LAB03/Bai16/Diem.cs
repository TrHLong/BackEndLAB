// Diem.cs
using System;

public class Diem
{
    public double X { get; set; }
    public double Y { get; set; }

    // Toán tử tạo lập
    public Diem()
    {
        X = 0;
        Y = 0;
    }

    public Diem(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Phương thức in một đối tượng Diem
    public void InDiem()
    {
        Console.WriteLine($"({X}, {Y})");
    }

    // Phương thức tính khoảng cách giữa hai điểm
    public double KhoangCach(Diem d2)
    {
        return Math.Sqrt(Math.Pow(d2.X - this.X, 2) + Math.Pow(d2.Y - this.Y, 2));
    }
}
