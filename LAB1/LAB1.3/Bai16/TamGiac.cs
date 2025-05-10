// TamGiac.cs
using System;

public class TamGiac
{
    public Diem D1 { get; set; }
    public Diem D2 { get; set; }
    public Diem D3 { get; set; }

    // Toán tử tạo lập không có đối số
    public TamGiac()
    {
        D1 = new Diem();
        D2 = new Diem();
        D3 = new Diem();
    }

    // Toán tử tạo lập có đối số
    public TamGiac(Diem d1, Diem d2, Diem d3)
    {
        D1 = d1;
        D2 = d2;
        D3 = d3;
    }

    // Phương thức tính chu vi tam giác
    public double TinhChuVi()
    {
        double ab = D1.KhoangCach(D2);
        double bc = D2.KhoangCach(D3);
        double ca = D3.KhoangCach(D1);
        return ab + bc + ca;
    }

    // Phương thức tính diện tích tam giác bằng công thức Heron
    public double TinhDienTich()
    {
        double a = D1.KhoangCach(D2);
        double b = D2.KhoangCach(D3);
        double c = D3.KhoangCach(D1);
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
