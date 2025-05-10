// Diem.cs
using System;

public class Diem
{
    public float X { get; set; }
    public float Y { get; set; }

    // Toán tử tạo lập
    public Diem()
    {
        X = 0;
        Y = 0;
    }

    public Diem(float x, float y)
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
    public float KhoangCach(Diem d2)
    {
        return (float)Math.Sqrt(Math.Pow(d2.X - this.X, 2) + Math.Pow(d2.Y - this.Y, 2));
    }
}
