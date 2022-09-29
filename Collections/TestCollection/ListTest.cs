using ConsoleApp1;
using NUnit.Framework;
using System.Linq;

namespace Test
{
    public class Tests
    {
        [Test]
        public void Check_First_Items()
        {
            MyList<int> list = new MyList<int>();
            list.AddItem(1);
            list.AddItem(2);
            list.AddItem(3);

            Assert.AreEqual(list.First(), 1);
        }

        [Test]
        public void Check_init_length()
        {
            int initSize = 5;

            MyList<int> list = new MyList<int>();

            Enumerable
                .Range(0, initSize)
                .Select(i =>
                {
                    list.AddItem(i);
                    return true;
                })
                .ToList();

            Assert.AreEqual(list.Count(), initSize);
        }

        [Test]
        public void Resize_List_and_read_all_values(
            [Range(5, 100, 5)] int initSize
            )
        {

            MyList<int> list = new MyList<int>();

            Enumerable
                .Range(0, initSize)
                .Select(i =>
                {
                    list.AddItem(i);
                    return true;
                })
                .ToList();

            var result = 0;

            list
                .Select((x, i) =>
                {
                    result += x == i ? 1 : 0;
                    return true;
                })
                .ToList();

            Assert.AreEqual(result, initSize);
        }

        [Test]
        public void Check_list_length()
        {
            int listSize = 15;

            MyList<int> list = new MyList<int>();

            var range = Enumerable
                 .Range(0, listSize);

            range.Select(i =>
                {
                    list.AddItem(i);
                    return true;
                })
                .ToList();

            Assert.AreEqual(listSize, list.Count());
        }

        [Test]
        public void Check_init_size()
        {
            MyList<int> list = new MyList<int>();
            Assert.AreEqual(0, list.Count());
        }

        [Test]
        public void Check_list_length_with_default_size()
        {
            MyList<int> list = new MyList<int>(4);
            Assert.AreEqual(4, list.Count());
        }
    }
}