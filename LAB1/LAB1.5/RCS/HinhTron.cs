using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS
{
    public class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public HinhTron(double r) => BanKinh = r;

        public override double TinhChuVi() => 2 * Math.PI * BanKinh;
        public override double TinhDienTich() => Math.PI * BanKinh * BanKinh;
    }
}
