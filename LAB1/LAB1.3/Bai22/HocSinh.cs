// HocSinh.cs
using System;

public class HocSinh
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public double TongDiem { get; set; }

    // Toán tử tạo lập không có đối số
    public HocSinh()
    {
        HoTen = "";
        NamSinh = 0;
        TongDiem = 0;
    }

    // Toán tử tạo lập có đối số
    public HocSinh(string hoTen, int namSinh, double tongDiem)
    {
        HoTen = hoTen;
        NamSinh = namSinh;
        TongDiem = tongDiem;
    }

    // Phương thức in thông tin học sinh, chữ cái đầu của họ tên chuyển thành chữ hoa
    public void InThongTin()
    {
        // Chuyển chữ cái đầu tiên của họ tên thành chữ hoa
        var words = HoTen.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }
        HoTen = string.Join(" ", words);

        Console.WriteLine($"{HoTen}, Năm sinh: {NamSinh}, Tổng điểm: {TongDiem}");
    }
}
