namespace GeometricFigure.Common
{
    public abstract class BasedPlaneFigure : IPlaneFigure
    {
        public const int ROUND_VALUE = 2;

        public Point[] Points { get; protected set; }

        public Point StartPoint
        {
            get
            {
                return Points.First();
            }
            protected set
            {
                Points[0] = value;
            }
        }

        public Point EndPoint
        {
            get
            {
                return Points.Last();
            }
            protected set
            {
                Points[^1] = value;
            }
        }

        public virtual double Perimetr
        {
            get
            {
                double perimetr = 0;

                for(int i = 0; i < Points.Length; i++)
                {
                    if (i == Points.Length - 1)
                        perimetr += new Line(Points[i], Points[0]).Length;
                    else
                        perimetr += new Line(Points[i], Points[i + 1]).Length;
                }

                return Math.Round(perimetr, ROUND_VALUE);
            }
        }

        public BasedPlaneFigure(params Point[] points)
        {
            if (points.Length <= 2) throw new Exception("Need at least 3 points");
            if (points.First().Equals(points.Last())) throw new Exception("Start and End points must be different");

            Points = points;
        }

        public abstract double GetSquare();
    }
}
