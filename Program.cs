using GeometricFigure;
using GeometricFigure.Common;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point 
                  a = new Point(0,0)
                , b = new Point(10,10)
                , c = new Point(0,90)
                ;

            var triangle = new Triangle(a, b, c);

            var right = triangle.IsRight;
            var square = triangle.GetSquare();
        }
    }
}
