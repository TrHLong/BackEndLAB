public class Sach : TaiLieu
{
    public string TenTacGia { get; set; }
    public int SoTrang { get; set; }

    public Sach(string maTaiLieu, string tenNhaXuatBan, int soBanPhatHanh, string tenTacGia, int soTrang)
        : base(maTaiLieu, tenNhaXuatBan, soBanPhatHanh)
    {
        TenTacGia = tenTacGia;
        SoTrang = soTrang;
    }

    public override void HienThi()
    {
        base.HienThi();
        Console.WriteLine($"Tên tác giả: {TenTacGia}");
        Console.WriteLine($"Số trang: {SoTrang}");
    }
}
