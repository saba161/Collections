using System.Collections;

namespace ConsoleApp1;

public class MyList<T> : IEnumerable<T>
{
    private int _size;
    private int _currentSize;
    private T[] _array;

    public MyList(int size = 0)
    {
        _array = new T[size];
    }

    public void AddItem(T item)
    {
        if (_currentSize == 0)
        {
            _size = 1;
            _array = new T[_size];
        }

        if (_currentSize >= _size)
        {
            T[] result = MergeTwoArray(_array);
            result[_currentSize] = item;
            _currentSize++;
            _size = result.Length;
            _array = result;
        }
        else
        {
            _array[_currentSize] = item;
            _currentSize++;
        }
    }

    public T First()
    {
        return _array[0];
    }

    private T[] MergeTwoArray(T[] first)
    {
        T[] newArray = new T[_size + 1];
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
        foreach (T item in _array)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}