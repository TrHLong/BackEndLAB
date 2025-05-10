namespace LAB 
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tuSo = 0, int mauSo = 1)
        {
            TuSo = tuSo;
            MauSo = mauSo == 0 ? 1 : mauSo;
        }

        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
            if (MauSo == 0) MauSo = 1;
        }

        public static PhanSo Cong(PhanSo a, PhanSo b)
        {
            int tu = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mau = a.MauSo * b.MauSo;
            return RutGon(new PhanSo(tu, mau));
        }

        public static PhanSo RutGon(PhanSo ps)
        {
            int gcd = GCD(Math.Abs(ps.TuSo), Math.Abs(ps.MauSo));
            ps.TuSo /= gcd;
            ps.MauSo /= gcd;
            return ps;
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
