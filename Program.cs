using System;
namespace ConsoleApp
{
    // Normal class
    class ListInt
    {
        private int[] _data;
        public int Count => _data.Length;
        public ListInt(int size) => _data = new int[size];
        public void Set(int index, int value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }
        public int Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(int); // return what???
        }
    }
    class ListChar
    {
        private char[] _data;
        public int Count => _data.Length;
        public ListChar(int size) => _data = new char[size];
        public void Set(int index, char value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }
        public char Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(char);
        }
    }

    // Generic class
    class List<T>
    {
        private T[] _data;
        public int Count => _data.Length;
        public List(int size) => _data = new T[size];
        public void Set(int index, T value)
        {
            if (index >= 0 && index < _data.Length) _data[index] = value;
        }
        public T Get(int index)
        {
            if (index >= 0 && index < _data.Length) return _data[index];
            return default(T);
        }
    }
    internal class Program
    {
        private static void Swap(ref int a, ref int b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        // Generic method
        private static void Swap<T>(ref T a, ref T b)
        {
            var temp = b;
            b = a;
            a = temp;
        }

        private static void Main(string[] args)
        {
            // Normal swap =))
            int a = 1, b = 2;
            Console.WriteLine($"Before: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After: a = {a}, b = {b}");

            // Swap<T> with int paras
            int aa = 1, bb = 2;
            Console.WriteLine($"Type = {aa.GetType()}");
            Console.WriteLine($"Before: aa = {aa}, bb = {bb}");
            Swap(ref aa, ref bb);
            Console.WriteLine($"After: aa = {aa}, bb = {bb}");

            // Swap<T> with boolean paras
            bool aaa = true, bbb = false;
            Console.WriteLine($"Type = {aaa.GetType()}");
            Console.WriteLine($"Before: aaa = {aaa}, bbb = {bbb}");
            Swap(ref aaa, ref bbb);
            Console.WriteLine($"After: aaa = {aaa}, bbb = {bbb}");

            // Normal ListInt =))
            var listInt = new ListInt(10);
            for (var i = 0; i < listInt.Count; i++)
                Console.Write($"{listInt.Get(i)}t");

            // Normal ListChar =))
            var listChar = new ListChar(10);
            for (var i = 0; i < listChar.Count; i++)
                Console.Write($"{listChar.Get(i)}t");

            // List<T> for int
            var listInt_1 = new List<int>(10);
            for (var i = 0; i < listInt_1.Count; i++)
                Console.Write($"{listInt_1.Get(i)}t");

            // List<T> for char
            var listChar_1 = new List<char>(10);
            for (var i = 0; i < listChar_1.Count; i++)
                Console.Write($"{listChar_1.Get(i)}t");

        }
    }
}

//todo check for null error when run the code
//todo continue with selection sort