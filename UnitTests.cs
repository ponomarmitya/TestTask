using System;
using Xunit;
using TestTask;

namespace XUnitTest
{
    public class UnitTests
    {
        #region Circle

        [Theory]
        [InlineData("1")]
        public void CircleReturnsAreaSuccess(string radius)
        {
            var circle = new Circle(Convert.ToDouble(radius));

            var result = circle.GetArea();

            Assert.IsType<double>(result);
        }

        [Theory]
        [InlineData("-1")]
        public void CircleCreateReturnsError(string radius)
        {
            Assert.Throws<CircleException>(() => new Circle(Convert.ToDouble(radius)));
        }

        #endregion

        #region Triangle

        [Theory]
        [InlineData("3", "4", "5")]
        public void TriangleReturnsAreaSuccess(string a, string b, string c)
        {
            var triangle = new Triangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));

            var result = triangle.GetArea();

            Assert.IsType<double>(result);
        }

        [Theory]
        [InlineData("1", "2", "4")]
        public void TriangleCreateReturnsInvalidSidesError(string a, string b, string c)
        {
            Assert.Throws<TriangleException>(() => new Triangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)));
        }

        [Theory]
        [InlineData("3", "-4", "5")]
        public void TriangleCreateReturnsNegativeSidesError(string a, string b, string c)
        {
            Assert.Throws<TriangleException>(() => new Triangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c)));
        }

        [Theory]
        [InlineData("3", "4", "5")]
        public void TriangleIsRectangularReturnsSuccess(string a, string b, string c)
        {
            var triangle = new Triangle(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));

            var result = triangle.IsRectangular();

            Assert.True(result);
        }

        #endregion

    }
}
