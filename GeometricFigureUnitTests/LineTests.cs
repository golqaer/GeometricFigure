using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureUnitTests
{
    public class LineTests
    {
        [Fact]
        public void Length()
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(1, 1)
                ;
            Line line = new Line(a, b);

            Assert.Equal(1.4, line.Length, 0.1);
        }
    }
}
