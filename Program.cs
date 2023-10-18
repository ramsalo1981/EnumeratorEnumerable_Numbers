using System.Collections;

namespace CAEnumeratorEnumerable_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ints = new FiveIntegers(1, 2, 3, 4, 5);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }

    class FiveIntegers : IEnumerable
    {
        int[] _value;

        public FiveIntegers(int n1, int n2, int n3, int n4, int n5)
        {
            _value = new int[] { n1, n2, n3, n4, n5 };
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _value)
            {
                yield return item;
            }
        }





        // we can use yield insted of all the code under

        //public IEnumerator GetEnumerator() => new Enumerator(this);

        //class Enumerator : IEnumerator
        //{
        //    int CurrentIndex = -1;
        //    FiveIntegers _Integers;

        //    public Enumerator(FiveIntegers integers)
        //    {
        //        _Integers = integers;
        //    }

        //    public object Current
        //    {
        //        get
        //        {
        //            if (CurrentIndex == -1)
        //            {
        //                throw new InvalidOperationException("Enumeration not Start");
        //            }
        //            if (CurrentIndex == _Integers._value.Length)
        //            {
        //                throw new InvalidOperationException("Enumeration has ended");
        //            }
        //            return _Integers._value[CurrentIndex];
        //        }
        //    }

        //    public bool MoveNext()
        //    {
        //        if (CurrentIndex >= _Integers._value.Length - 1)
        //        {
        //            return false;
        //        }
        //        return ++CurrentIndex < _Integers._value.Length;
        //    }

        //    public void Reset()
        //    {
        //        CurrentIndex = -1;
        //    }
        //}
    }
}