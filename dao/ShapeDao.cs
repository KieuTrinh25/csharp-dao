using Dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.dao
{
    public interface ShapeDao
    {
        public void insert(Shape shape);
        public void update(Shape shape);
        public List<Shape> findAll();
        public List<Shape> findByShapeId(int shapeId);
        public Shape findById(int shapeId);

        public void deleteById(int shapeId);
    }
}
