// BienLai.cs
using System;

public class BienLai
{
    public KhachHang KhachHang { get; set; }
    public int ChiSoCu { get; set; }
    public int ChiSoMoi { get; set; }
    public double SoTienPhaiTra { get; set; }

    public BienLai(KhachHang khachHang, int chiSoCu, int chiSoMoi)
    {
        KhachHang = khachHang;
        ChiSoCu = chiSoCu;
        ChiSoMoi = chiSoMoi;
        TinhTien();
    }

    private void TinhTien()
    {
        int soDienSuDung = ChiSoMoi - ChiSoCu;
        if (soDienSuDung <= 50)
        {
            SoTienPhaiTra = soDienSuDung * 1250;
        }
        else if (soDienSuDung <= 100)
        {
            SoTienPhaiTra = 50 * 1250 + (soDienSuDung - 50) * 1500;
        }
        else
        {
            SoTienPhaiTra = 50 * 1250 + 50 * 1500 + (soDienSuDung - 100) * 2000;
        }
    }

    public void HienThiThongTin()
    {
        KhachHang.HienThi();
        Console.WriteLine($"Chỉ số cũ: {ChiSoCu}, Chỉ số mới: {ChiSoMoi}, Tiền điện phải trả: {SoTienPhaiTra} VND");
    }
}
