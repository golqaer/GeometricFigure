using GeometricFigure.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Triangle : BasedPlaneFigure
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

        public double AB
        {
            get
            {
                return new Line(A, B).Length;
            }
        }
        public double BC
        {
            get
            {
                return new Line(B, C).Length;
            }
        }
        public double CA
        {
            get
            {
                return new Line(C, A).Length;
            }
        }

        /// <summary>
        /// Треугольник прямоугольный
        /// </summary>
        public bool IsRight
        {
            get
            {
                return GetIsRight();
            }
        }

        public Triangle(Point a, Point b, Point c) : base (a, b, c)
        { }

        private bool GetIsRight()
        {
            double[] lines = {AB, BC, CA};

            var maxIndex = Array.IndexOf(lines, lines.Max());
            double abSquaredSum = 0;

            for(int i = 0; i < lines.Length; i++)
            {
                if (i != maxIndex) abSquaredSum += Math.Pow(lines[i], 2);
            }

            double cSquared = Math.Pow(lines[maxIndex], 2);

            return Math.Round(cSquared, ROUND_VALUE) == Math.Round(abSquaredSum, ROUND_VALUE);
        }

        public override double GetSquare()
        {
            var p = Perimetr/2;

            var result = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));

            return Math.Round(result, ROUND_VALUE);
        }
    }
}
