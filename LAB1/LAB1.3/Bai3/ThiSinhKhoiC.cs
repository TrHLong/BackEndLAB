public class ThiSinhKhoiC : ThiSinh
{
    public double DiemVan { get; set; }
    public double DiemSu { get; set; }
    public double DiemDia { get; set; }

    public ThiSinhKhoiC(string soBaoDanh, string hoTen, string diaChi, int uuTien, double diemVan, double diemSu, double diemDia)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        DiemVan = diemVan;
        DiemSu = diemSu;
        DiemDia = diemDia;
    }

    public double TinhDiemTong()
    {
        return DiemVan + DiemSu + DiemDia;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Điểm Văn: {DiemVan}");
        Console.WriteLine($"Điểm Sử: {DiemSu}");
        Console.WriteLine($"Điểm Địa: {DiemDia}");
        Console.WriteLine($"Tổng điểm: {TinhDiemTong()}");
    }
}
