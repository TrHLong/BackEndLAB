public class ThiSinhKhoiA : ThiSinh
{
    public double DiemToan { get; set; }
    public double DiemLy { get; set; }
    public double DiemHoa { get; set; }

    public ThiSinhKhoiA(string soBaoDanh, string hoTen, string diaChi, int uuTien, double diemToan, double diemLy, double diemHoa)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        DiemToan = diemToan;
        DiemLy = diemLy;
        DiemHoa = diemHoa;
    }

    public double TinhDiemTong()
    {
        return DiemToan + DiemLy + DiemHoa;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Điểm Toán: {DiemToan}");
        Console.WriteLine($"Điểm Lý: {DiemLy}");
        Console.WriteLine($"Điểm Hóa: {DiemHoa}");
        Console.WriteLine($"Tổng điểm: {TinhDiemTong()}");
    }
}
