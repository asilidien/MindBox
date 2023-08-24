using TestTaskMindBox;

namespace TestTaskMindBoxTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestCircle()
        {
            IFigure circle = new Circle(2);
            double area = 12.57d;

            Assert.That(area, Is.EqualTo(circle.CalculateArea()));
        }

        [Test]
        public void TestCircleWithNegativeParams()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-2));
        }

        [Test]
        public void TestTriangle()
        {
            IFigure triangle = new Triangle(4, 5, 8);

            double area = 8.18d;

            Assert.That(triangle.CalculateArea(), Is.EqualTo(area));
        }

        [Test]
        public void TestRightTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double area = 3.5d;
            Assert.That(triangle.TriangleIsRight(), Is.EqualTo(true));
            Assert.That(triangle.CalculateArea(), Is.EqualTo(area));
        }

        [Test]
        public void TestTriangleWithNegativeParams()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-5,-5,-9));
        }

        [Test]
        public void TestTriangleWithInvalidParams()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(4, 5, 10));
        }
    }
}