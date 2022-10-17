using Dao.dao;
using Dao.model;

namespace Dao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeDao shapeDao = new ShapeFileImplement();

            List<Shape> shapeList = shapeDao.findAll();
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape);
            }
        }
    }
}