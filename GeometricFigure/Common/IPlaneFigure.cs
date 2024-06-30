using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Common
{
    public interface IPlaneFigure
    {
        Point StartPoint { get; }
        Point EndPoint { get; }
        double Perimetr { get; }
    }
}
