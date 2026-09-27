using Tyuiu.IvashkinLA.Sprint1.Task0.V29.Lib;

namespace Tyuiu.IvashkinLA.Sprint1.Task0.V29.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.That(res, Is.EqualTo(32));
        }
    }
}