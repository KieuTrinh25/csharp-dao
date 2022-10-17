using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.model
{
    public abstract class Shape
    {
        public int id;
        public Shape(int id)
        {
            this.id = id;
        }

        public abstract double ChuVi();
        public abstract double DienTich();
    }
}
