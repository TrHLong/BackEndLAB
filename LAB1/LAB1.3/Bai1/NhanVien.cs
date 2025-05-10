// NhanVien.cs
public class NhanVien : CanBo
{
    public string CongViec { get; set; }

    public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        CongViec = congViec;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Công việc: {CongViec}");
    }
}
