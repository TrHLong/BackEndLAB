using LAB;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

List<PhanSo> danhSach = new List<PhanSo>();

Console.Write("Nhập số lượng phân số: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Phân số {i + 1}:");
    var ps = new PhanSo();
    ps.Nhap();
    danhSach.Add(ps);
}

// Tính tổng
PhanSo tong = danhSach[0];
for (int i = 1; i < danhSach.Count; i++)
{
    tong = PhanSo.Cong(tong, danhSach[i]);
}

Console.WriteLine($"Tổng các phân số: {tong}");
