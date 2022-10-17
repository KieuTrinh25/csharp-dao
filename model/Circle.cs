using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.model
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(int id, double radius) : base(id)
        {
            this.radius = radius;
        }

        public override double ChuVi()
        {
            return Math.PI * radius * 2;
        }

        public override double DienTich()
        {
            return Math.PI * Math.PI * radius;
        }

        public override string ToString()
        {
            return String.Format("Circle-{0}:{1}:{2}", id, ChuVi(), DienTich());
        }
    }
}
