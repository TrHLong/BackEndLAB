using RCS;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<Hinh> danhSachHinh = new List<Hinh>
{
    new HinhTron(3),
    new HinhVuong(4),
    new HinhChuNhat(5, 3),
    new HinhTamGiac(3, 4, 5)
};

double tongChuVi = danhSachHinh.Sum(h => h.TinhChuVi());
double tongDienTich = danhSachHinh.Sum(h => h.TinhDienTich());

Console.WriteLine($"Tổng chu vi: {tongChuVi:F2}");
Console.WriteLine($"Tổng diện tích: {tongDienTich:F2}");
