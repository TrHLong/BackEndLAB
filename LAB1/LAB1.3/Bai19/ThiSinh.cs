// Thisinh.cs
using System;

public class Thisinh
{
    // Cấu trúc Họ tên
    public struct HoTen
    {
        public string Ho;
        public string TenDem;
        public string Ten;
    }

    // Cấu trúc Quê quán
    public struct QueQuan
    {
        public string Xa;
        public string Huyen;
        public string Tinh;
    }

    // Cấu trúc Điểm thi
    public struct DiemThi
    {
        public double Toan;
        public double Ly;
        public double Hoa;
    }

    public HoTen Hten { get; set; }
    public QueQuan Qquan { get; set; }
    public string Truong { get; set; }
    public int Tuoi { get; set; }
    public string SoBaoDanh { get; set; }
    public DiemThi Diem { get; set; }

    // Toán tử tạo lập không có đối số
    public Thisinh()
    {
        Hten.Ho = "";
        Hten.TenDem = "";
        Hten.Ten = "";
        Qquan.Xa = "";
        Qquan.Huyen = "";
        Qquan.Tinh = "";
        Truong = "";
        Tuoi = 0;
        SoBaoDanh = "";
        Diem.Toan = 0;
        Diem.Ly = 0;
        Diem.Hoa = 0;
    }

    // Toán tử tạo lập có đối số
    public Thisinh(string ho, string tenDem, string ten, string xa, string huyen, string tinh, string truong, int tuoi, string soBaoDanh, double toan, double ly, double hoa)
    {
        Hten.Ho = ho;
        Hten.TenDem = tenDem;
        Hten.Ten = ten;
        Qquan.Xa = xa;
        Qquan.Huyen = huyen;
        Qquan.Tinh = tinh;
        Truong = truong;
        Tuoi = tuoi;
        SoBaoDanh = soBaoDanh;
        Diem.Toan = toan;
        Diem.Ly = ly;
        Diem.Hoa = hoa;
    }

    // Phương thức tính tổng điểm ba môn
    public double TongDiem()
    {
        return Diem.Toan + Diem.Ly + Diem.Hoa;
    }

    // Phương thức hiển thị thông tin về thí sinh
    public void InThongTin()
    {
        Console.WriteLine($"{Hten.Ho} {Hten.TenDem} {Hten.Ten}, Quê quán: {Qquan.Xa}, {Qquan.Huyen}, {Qquan.Tinh}, Trường: {Truong}, Tuổi: {Tuoi}, Số báo danh: {SoBaoDanh}");
        Console.WriteLine($"Điểm thi: Toán: {Diem.Toan:0.00}, Lý: {Diem.Ly:0.00}, Hóa: {Diem.Hoa:0.00}");
    }
}
