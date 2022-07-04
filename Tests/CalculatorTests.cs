namespace Tests
{
    public class CalculatorTests
    {
        [Test]
        public void TriangleAreaTest()
        {
            double a, b, c;
            a = 9;
            b = 5;
            c = 12;
            var result = Math.Round(Calculator.GetTriangleArea(a, b, c),3);
            Assert.AreEqual(20.396, result);
        }
        [Test]
        public void CircleAreaTest()
        {
            double radius = 13;
            var result = Math.Round(Calculator.GetCircleArea(radius), 2);
            Assert.AreEqual(81.68, result);
        }
    }
}