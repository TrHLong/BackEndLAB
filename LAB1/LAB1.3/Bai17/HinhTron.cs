// HinhTron.cs
using System;

public class HinhTron
{
    public Diem Tam { get; set; }
    public float BanKinh { get; set; }

    // Toán tử tạo lập không có đối số
    public HinhTron()
    {
        Tam = new Diem();
        BanKinh = 0;
    }

    // Toán tử tạo lập có đối số
    public HinhTron(Diem d, float bk)
    {
        Tam = d;
        BanKinh = bk;
    }

    // Phương thức tính chu vi
    public float TinhChuVi()
    {
        return 2 * (float)Math.PI * BanKinh;
    }

    // Phương thức tính diện tích
    public float TinhDienTich()
    {
        return (float)Math.PI * BanKinh * BanKinh;
    }

    // Phương thức kiểm tra giao với hình tròn khác
    public bool KiemTraGiao(HinhTron hinhTronKhac)
    {
        float khoangCachGiuaTam = Tam.KhoangCach(hinhTronKhac.Tam);
        return khoangCachGiuaTam <= (this.BanKinh + hinhTronKhac.BanKinh) && khoangCachGiuaTam >= Math.Abs(this.BanKinh - hinhTronKhac.BanKinh);
    }
}
