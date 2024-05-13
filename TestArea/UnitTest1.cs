using FindArea.Library.Algo;

namespace TestArea
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 28.27)]
        [InlineData(3.13, 30.78)]
        public void TestCircle(double radius, double expectedResult)
        {
            var circle = new Circle(radius);
            var result = circle.GetArea();
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(3,3,9)]
        [InlineData(3,2,6)]
        [InlineData(3.12,3,9.36)]
        public void TestRectangle(double width, double height, double expectedResult)
        {
            var rectangle = new Rectangle(width, height);
            var result = rectangle.GetArea();
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(3,5,6, 7.48)]
        [InlineData(5,5,6, 12)]
        [InlineData(3.12,5.34,6, 8.31)]

        public void TestTriangle(double firstSide , double secondSide, double thirdSide, double expectedResult)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.GetArea();
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(8, 15, 17, true)]
        [InlineData(3.52, 5, 6, false)]
        public void TestIsRightT(double firstSide, double secondSide, double thirdSide, bool expectedResult)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var result = triangle.IsRightTriangle();
            Assert.Equal(expectedResult, result);
        }
    }
}