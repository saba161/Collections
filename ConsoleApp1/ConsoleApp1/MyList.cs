using System.Collections;

namespace ConsoleApp1
{
    public class MyList<T> : IEnumerable<T>
    {
        private int size;
        private int currentSize;
        private T[] array;

        public MyList(int size = 5)
        {
            array = new T[size];
            this.size = size;
        }

        public void AddItem(T item)
        {
            if (currentSize >= size)
            {
                T[] result = MergeTwoArray(array);
                result[currentSize] = item;
                currentSize++;
                size = result.Length;
                array = result;
            }
            else
            {
                array[currentSize] = item;
                currentSize++;
            }
        }

        public T First()
        {
            return array[0];
        }

        private T[] MergeTwoArray(T[] first)
        {
            T[] newArray = new T[size * 2];
            int i = 0;
            foreach (T item in first)
            {
                newArray[i] = item;
                i++;
            }
            return newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}