// VanBan.cs
using System;

public class VanBan
{
    public string XauKyTu { get; set; }

    // Hàm tạo không có đối số
    public VanBan()
    {
        XauKyTu = string.Empty;
    }

    // Hàm tạo có đối số
    public VanBan(string st)
    {
        XauKyTu = st;
    }

    // Phương thức đếm số từ trong xâu
    public int DemSoTu()
    {
        if (string.IsNullOrWhiteSpace(XauKyTu))
        {
            return 0;
        }

        string[] tu = XauKyTu.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return tu.Length;
    }

    // Phương thức đếm số ký tự H (không phân biệt chữ hoa, chữ thường)
    public int DemSoKyTuH()
    {
        int count = 0;
        foreach (char c in XauKyTu)
        {
            if (char.ToLower(c) == 'h') // Kiểm tra ký tự H không phân biệt chữ hoa và chữ thường
            {
                count++;
            }
        }
        return count;
    }

    // Phương thức chuẩn hóa xâu
    public void ChuanHoaXau()
    {
        if (string.IsNullOrWhiteSpace(XauKyTu))
        {
            return;
        }

        // Xóa khoảng trắng ở đầu và cuối
        XauKyTu = XauKyTu.Trim();

        // Thay thế khoảng trắng liền nhau bằng một khoảng trắng duy nhất
        string[] words = XauKyTu.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        XauKyTu = string.Join(" ", words);
    }

    // Phương thức hiển thị xâu
    public void HienThi()
    {
        Console.WriteLine("Xâu văn bản: " + XauKyTu);
    }
}
