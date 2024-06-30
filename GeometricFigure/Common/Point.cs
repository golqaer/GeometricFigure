using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Common
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point point)
                return point.X == X && point.Y == Y;
            else
                return false;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
