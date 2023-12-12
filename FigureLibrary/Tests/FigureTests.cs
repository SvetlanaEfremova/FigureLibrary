using FigureLibrary.Figures;
using NUnit.Framework;

namespace FigureLibrary.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void CircleArea_ShouldBeCorrect()
        {
            var circle = new Circle(2);
            var expectedArea = Math.PI * 4;
            Assert.AreEqual(expectedArea, circle.CalculateArea());
        }

        [Test]
        public void CircleArea_ShouldBeIncorrect()
        {
            var circle = new Circle(2);
            var expectedArea = Math.PI * 3;
            Assert.AreNotEqual(expectedArea, circle.CalculateArea());
        }

        [Test]
        public void TriangleArea_ShouldBeCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 6;
            Assert.AreEqual(expectedArea, triangle.CalculateArea());
        }

        [Test]
        public void TriangleArea_ShouldBeIncorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            var expectedArea = 5;
            Assert.AreNotEqual(expectedArea, triangle.CalculateArea());
        }

        [Test]
        public void Triangle_IsRightAngled_ShouldBeTrue()
        {
            var rightAngledTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightAngledTriangle.IsRight());
        }

        [Test]
        public void Triangle_IsRightAngled_ShouldBeFalse()
        {
            var notRightAngledTriangle = new Triangle(3, 4, 6);
            Assert.IsFalse(notRightAngledTriangle.IsRight());
        }

        [Test]
        public void CalculateArea_UnknownShape_ShouldBeCorrect()
        {
            Figure myCircle = new Circle(3);
            Figure myTriangle = new Triangle(3, 4, 5);
            Assert.AreEqual(Math.PI * 9, myCircle.CalculateArea());
            Assert.AreEqual(6, myTriangle.CalculateArea());
        }
    }
}
