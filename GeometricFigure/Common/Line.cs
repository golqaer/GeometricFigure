using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Common
{
    public struct Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public double Length
        {
            get
            {
                var result = Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
                return result;
            }
        }

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}
