using GeometricShapes;
namespace GeometricShapesTests
{
    public class UnitTest1
    {
        [Fact]
        public void IsCorrectInput()
        {
            var shape1 = new Shape(1);
            Assert.Equal(Math.PI, shape1.Square());

            var shape2 = new Triangle(3, 4, 5);
            Assert.Equal(6, shape2.Square());
        }

        [Fact]
        public void IsIncorrectInput()
        {
            var shape1 = new Shape(-10);
            Assert.Throws<ArgumentException>(() => shape1.Square());

            var shape2 = new Triangle(55, 4, 5);
            Assert.Throws<ArgumentException>(() => shape2.Square());
        }
    }
}