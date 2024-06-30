using GeometricFigure;
using GeometricFigure.Common;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(5, 2)
                ;
            Quadrangle quadrangle = new Rectangle(a, b);
        }
    }
}
