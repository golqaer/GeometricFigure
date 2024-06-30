using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Ellipse : Rectangle
    {

        public Ellipse(Point startPoint, Point endPoint) : base (startPoint, endPoint)
        {

        }

        public override double GetSquare()
        {
            var a = new Line(A, B).Length / 2;
            var b = new Line(B, C).Length / 2;

            var result = Math.PI * a * b;

            return Math.Round(result, ROUND_VALUE);
        }
    }
}
