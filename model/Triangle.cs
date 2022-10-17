using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.model
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public Triangle(int id,double a, double b, double c) : base(id)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public override double ChuVi()
        {
            return a + b + c;
        }

        public override double DienTich()
        {
            double p = ChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override string ToString()
        {
            return String.Format("Triangle-{0}:{1}:{2}", id, ChuVi(), DienTich());
        }
    }
}
