namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            _calc = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSum()
        {
            Assert.AreEqual(5, _calc.add(2, 3));
        }

        [Test]
        public void Subtract_ShouldReturnDifference()
        {
            Assert.AreEqual(2, _calc.Subtract(5, 3));
        }

        [Test]
        public void Multiply_ShouldReturnProduct()
        {
            Assert.AreEqual(15, _calc.Multiply(5, 3));
        }

        [Test]
        public void Divide_ShouldReturnQuotient()
        {
            Assert.AreEqual(2, _calc.Divide(6, 3));
        }

        [Test]
        public void Divide_ByZero_ShouldThrow()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
        }
    }
}