public class ThiSinh
{
    public string SoBaoDanh { get; set; }
    public string HoTen { get; set; }
    public string DiaChi { get; set; }
    public int UuTien { get; set; }

    public ThiSinh(string soBaoDanh, string hoTen, string diaChi, int uuTien)
    {
        SoBaoDanh = soBaoDanh;
        HoTen = hoTen;
        DiaChi = diaChi;
        UuTien = uuTien;
    }

    public virtual void HienThi()
    {
        Console.WriteLine($"Số báo danh: {SoBaoDanh}");
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
        Console.WriteLine($"Ưu tiên: {UuTien}");
    }
}
