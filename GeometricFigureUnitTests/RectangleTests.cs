using GeometricFigure;
using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureUnitTests
{
    public class RectangleTests
    {
        [Fact]
        public void PointTests() 
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(5, 2)
                ;
            Quadrangle quadrangle = new Rectangle(a, b);

            Assert.True(quadrangle.A.Equals(new Point(0, 0)));
            Assert.True(quadrangle.B.Equals(new Point(0, 2)));
            Assert.True(quadrangle.C.Equals(new Point(5, 2)));
            Assert.True(quadrangle.D.Equals(new Point(5, 0)));
        }
    }
}
