using GeometricFigure;
using GeometricFigure.Common;

namespace GeometricFigureUnitTests
{
    public class BasedPlaneFigureTests
    {
        private class TestFigure : BasedPlaneFigure
        {
            public TestFigure() :base (new Point(0, 0), new Point(1,1))
            { }

            public override double GetSquare()
            {
                throw new NotImplementedException();
            }
        }


        [Fact]
        public void Perimetr()
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(10, 10)
                , c = new Point(0, 20)
                ;
            BasedPlaneFigure figure = new Triangle(a, b, c);

            double result = figure.Perimetr;

            Assert.Equal(48.28, result);
        }

        [Fact]
        public void ConstructorPointEqualsException()
        {
            Point
                  a = new Point(0, 0)
                , b = new Point(10, 10)
                , c = new Point(0, 0)
                ;
            

            Assert.Throws<Exception>(() =>
            {
                BasedPlaneFigure figure = new Triangle(a, b, c);
            });
        }

        [Fact]
        public void ConstructorPointCountException()
        {
            Assert.Throws<Exception>(() =>
            {
                BasedPlaneFigure figure = new TestFigure();
            });
        }
    }
}