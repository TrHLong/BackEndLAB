// CanBo.cs
using LAB03.Common;

public class CanBo
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string GioiTinh { get; set; }
    public string DiaChi { get; set; }

    public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        GioiTinh = gioiTinh;
        DiaChi = diaChi;
    }

    public virtual void HienThi()
    {
        GlobalConfig.SetupConsole();
        Console.WriteLine($"Họ tên: {HoTen}");
        Console.WriteLine($"Năm sinh: {NamSinh}");
        Console.WriteLine($"Giới tính: {GioiTinh}");
        Console.WriteLine($"Địa chỉ: {DiaChi}");
    }
}
