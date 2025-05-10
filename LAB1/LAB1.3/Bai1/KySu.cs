// KySu.cs
public class KySu : CanBo
{
    public string NganhDaoTao { get; set; }

    public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganhDaoTao)
        : base(hoTen, namSinh, gioiTinh, diaChi)
    {
        NganhDaoTao = nganhDaoTao;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Ngành đào tạo: {NganhDaoTao}");
    }
}
