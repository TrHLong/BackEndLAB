// CongNhan.cs
public class CongNhan : CanBo
{
    public string Bac { get; set; }

    public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        Bac = bac;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Bậc công nhân: {Bac}");
    }
}
