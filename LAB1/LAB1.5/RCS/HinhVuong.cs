using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS
{
    public class HinhVuong : Hinh
    {
        public double Canh { get; set; }

        public HinhVuong(double a) => Canh = a;

        public override double TinhChuVi() => 4 * Canh;
        public override double TinhDienTich() => Canh * Canh;
    }
}
