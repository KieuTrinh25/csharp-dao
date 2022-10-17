using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.model
{
    public class Rect : Shape
    {
        private double a;
        private double b;
        public Rect(int id, double a, double b) : base(id)
        {
            this.a = a;
            this.b = b;
        }

        public override double ChuVi()
        {
            return (a + b) * 2;
        }

        public override double DienTich()
        {
            return a * b;
        }
        public override string ToString()
        {
            return String.Format("Rect-{0}:{1}:{2}", id, ChuVi(), DienTich());
        }
    }
}
