public class ThiSinhKhoiB : ThiSinh
{
    public double DiemToan { get; set; }
    public double DiemHoa { get; set; }
    public double DiemSinh { get; set; }

    public ThiSinhKhoiB(string soBaoDanh, string hoTen, string diaChi, int uuTien, double diemToan, double diemHoa, double diemSinh)
        : base(soBaoDanh, hoTen, diaChi, uuTien)
    {
        DiemToan = diemToan;
        DiemHoa = diemHoa;
        DiemSinh = diemSinh;
    }

    public double TinhDiemTong()
    {
        return DiemToan + DiemHoa + DiemSinh;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Điểm Toán: {DiemToan}");
        Console.WriteLine($"Điểm Hóa: {DiemHoa}");
        Console.WriteLine($"Điểm Sinh: {DiemSinh}");
        Console.WriteLine($"Tổng điểm: {TinhDiemTong()}");
    }
}
