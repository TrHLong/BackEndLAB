// TheMuon.cs
using System;

public class TheMuon
{
    public string SoPhieuMuon { get; set; }
    public DateTime NgayMuon { get; set; }
    public DateTime HanTra { get; set; }
    public string SoHieuSach { get; set; }
    public SinhVien SinhVien { get; set; }

    public TheMuon(string soPhieuMuon, DateTime ngayMuon, DateTime hanTra, string soHieuSach, SinhVien sinhVien)
    {
        SoPhieuMuon = soPhieuMuon;
        NgayMuon = ngayMuon;
        HanTra = hanTra;
        SoHieuSach = soHieuSach;
        SinhVien = sinhVien;
    }

    public void HienThiThongTin()
    {
        SinhVien.HienThi();
        Console.WriteLine($"Số phiếu mượn: {SoPhieuMuon}, Ngày mượn: {NgayMuon.ToShortDateString()}, Hạn trả: {HanTra.ToShortDateString()}, Số hiệu sách: {SoHieuSach}");
    }

    public bool DaDenHan(DateTime currentDate)
    {
        return HanTra <= currentDate;
    }

    public bool TimKiemTheoMaSoSinhVien(string maSoSinhVien)
    {
        return SinhVien.MaSoSinhVien.Equals(maSoSinhVien, StringComparison.OrdinalIgnoreCase);
    }
}
