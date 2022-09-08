using ConsoleApp1;
using NUnit.Framework;

namespace TestCollection
{
    public class Tests
    {
        [Test]
        public void Test_First_Items()
        {
            MyList<int> list = new MyList<int>();
            list.AddItem(1);
            list.AddItem(2);
            list.AddItem(3);

            Assert.AreEqual(list.First(), 1);
        }
    }
}