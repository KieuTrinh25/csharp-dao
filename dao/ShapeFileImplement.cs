using Dao.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.dao
{
    public class ShapeFileImplement : ShapeDao
    {
        List<Shape> shapeList = new List<Shape>();
        private int id = 0;

        public ShapeFileImplement()
        {
            loadFromFile();
        }

        private void loadFromFile()
        {
            StreamReader reader = new StreamReader(@"D:\input.txt");
            while (reader.Peek() >= 0)
            {
                string line = reader.ReadLine();
                switch (line.ToLower())
                {
                    case "#circle":
                        shapeList.Add(readCircle(reader));
                        break;
                    case "#rect":
                        shapeList.Add(readRect(reader));
                        break;
                    case "#triangle":
                        shapeList.Add(readTriangle(reader));
                        break;
                }
            }
        }

        private Shape readTriangle(StreamReader reader)
        {
            id++;
            double a = Double.Parse(reader.ReadLine());
            double b = Double.Parse(reader.ReadLine());
            double c = Double.Parse(reader.ReadLine());
            return new Triangle(id, a, b, c);
        }

        private Shape readRect(StreamReader reader)
        {
            id++;
            double a = Double.Parse(reader.ReadLine());
            double b = Double.Parse(reader.ReadLine());
            return new Rect(id, a, b);
        }

        private Shape readCircle(StreamReader reader)
        {
            id++;
            double radius = Double.Parse(reader.ReadLine());
            return new Circle(id, radius);
        }

        public void deleteById(int shapeId)
        {
            throw new NotImplementedException();
        }

        public List<Shape> findAll()
        {
            return shapeList;
        }

        public Shape findById(int shapeId)
        {
            throw new NotImplementedException();
        }

        public List<Shape> findByShapeId(int shapeId)
        {
            throw new NotImplementedException();
        }

        public void insert(Shape shape)
        {
            throw new NotImplementedException();
        }

        public void update(Shape shape)
        {
            throw new NotImplementedException();
        }
    }
}
