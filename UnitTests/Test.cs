using NUnit.Framework;
using System;
namespace UnitTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Test_if_class_is_instantiable()
        {
            var credit = new Credit();
            Assert.IsInstanceOf<Credit>(credit);
        }
    }
}
