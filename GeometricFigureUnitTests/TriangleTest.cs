using GeometricFigure;
using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureUnitTests
{
    public class TriangleTest
    {
        [Fact]
        public void Square()
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(10, 10)
                , c = new Point(0, 20)
                ;
            var triangle = new Triangle(a,b,c);

            Assert.Equal(100, triangle.GetSquare(), 0.5);
        }

        [Fact]
        public void IsRight()
        {
            Point
                  a1 = new Point(0, 0)
                , b1 = new Point(10, 10)
                , c1 = new Point(0, 20)
                ;
            var triangle1 = new Triangle(a1, b1, c1);

            Point
                  a2 = new Point(0, 0)
                , b2 = new Point(10, 10)
                , c2 = new Point(0, 200)
                ;
            var triangle2 = new Triangle(a2, b2, c2);



            Assert.True(triangle1.IsRight);
            Assert.False(triangle2.IsRight);
        }
    }
}
