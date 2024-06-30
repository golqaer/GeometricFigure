using GeometricFigure;
using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureUnitTests
{
    public class CircleTests
    {
        [Fact]
        public void SquareTest()
        {
            var circle = new Circle(5);

            Assert.Equal(78.54, circle.GetSquare());
        }

        [Fact]
        public void PointTests()
        {
            Ellipse circle = new Circle(5, new Point(0, 0));

            Assert.True(circle.A.Equals(new Point(-5, -5)));
            Assert.True(circle.B.Equals(new Point(-5, 5)));
            Assert.True(circle.C.Equals(new Point(5, 5)));
            Assert.True(circle.D.Equals(new Point(5, -5)));
        }
    }
}
