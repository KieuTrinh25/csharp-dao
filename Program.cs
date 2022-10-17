using Dao.dao;
using Dao.model;

namespace Dao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeDao shapeDao = new ShapeMySQLImplement();

            Shape c = new Circle(1, 10);
            shapeDao.insert(c);

            Shape r = new Rect(1, 10, 15);
            shapeDao.insert(r);

            Shape t = new Triangle(1, 10, 15, 16);
            shapeDao.insert(t);

            List<Shape> shapeList = shapeDao.findAll();
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape);
            }
        }
    }
}