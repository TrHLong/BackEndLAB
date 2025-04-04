// TamGiac.cs
using System;

public class TamGiac : DaGiac
{
    public TamGiac(int a, int b, int c) : base(3)
    {
        CacCanh[0] = a;
        CacCanh[1] = b;
        CacCanh[2] = c;
    }

    // Phương thức tính chu vi tam giác
    public override int TinhChuVi()
    {
        return CacCanh[0] + CacCanh[1] + CacCanh[2];
    }

    // Phương thức tính diện tích tam giác theo công thức Heron
    public double TinhDienTich()
    {
        double p = TinhChuVi() / 2.0;
        double dienTich = Math.Sqrt(p * (p - CacCanh[0]) * (p - CacCanh[1]) * (p - CacCanh[2]));
        return dienTich;
    }

    // Kiểm tra định lý Pythagoras
    public bool KiemTraDinhLyPitago()
    {
        // Sắp xếp các cạnh để đảm bảo cạnh lớn nhất là cạnh huyền
        Array.Sort(CacCanh);
        return (CacCanh[0] * CacCanh[0] + CacCanh[1] * CacCanh[1] == CacCanh[2] * CacCanh[2]);
    }
}
