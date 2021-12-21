using BusinessLogic;
using NUnit.Framework;

namespace BusinessLogicTests
{
    public class Tests
    {    
        [Test]
        public void Test1()
        {
            Assert.AreEqual(7 , 5.Add(2));
        }
    }
}