// DaGiac.cs
using System;

public class DaGiac
{
    public int SoCanh { get; set; }
    public int[] CacCanh { get; set; }

    public DaGiac(int soCanh)
    {
        SoCanh = soCanh;
        CacCanh = new int[soCanh];
    }

    // Phương thức tính chu vi
    public virtual int TinhChuVi()
    {
        int chuVi = 0;
        for (int i = 0; i < SoCanh; i++)
        {
            chuVi += CacCanh[i];
        }
        return chuVi;
    }

    // Phương thức in giá trị các cạnh
    public void InCacCanh()
    {
        Console.WriteLine("Các cạnh của đa giác:");
        for (int i = 0; i < SoCanh; i++)
        {
            Console.Write(CacCanh[i] + " ");
        }
        Console.WriteLine();
    }
}
