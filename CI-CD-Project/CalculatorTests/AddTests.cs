using CI_CD_Project;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void Add()
        {
            var result = Calculator.Add(10, 20);
            Assert.Equals(30, result);
        }
    }
}
