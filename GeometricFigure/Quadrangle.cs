using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Common;

namespace GeometricFigure
{
    public class Quadrangle : BasedPlaneFigure
    {
        public Point A
        {
            get
            {
                return Points[0];
            }
        }
        public Point B
        {
            get
            {
                return Points[1];
            }
        }
        public Point C
        {
            get
            {
                return Points[2];
            }
        }
        public Point D
        {
            get
            {
                return Points[3];
            }
        }

        public Quadrangle(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {

        }

        public override double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
