using Dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.dao
{
    public class ShapeImplement : ShapeDao
    {
        List<Shape> shapes = new List<Shape>();
        public void deleteById(int shapeId)
        {
            throw new NotImplementedException();
        }

        public List<Shape> findAll()
        {
            return shapes;
        }

        public Shape findById(int shapeId)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.id == shapeId) return shape;
            }
            return null;
        }

        public List<Shape> findByShapeId(int shapeId)
        {
            throw new NotImplementedException();
        }

        public void insert(Shape shape)
        {
            shapes.Add(shape);
        }

        public void update(Shape shape)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if(shapes[i] == shape)
                {
                    shapes[i] = shape;
                }
            }
        }
    }
}
