using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace KeyValueStore
{
    public class Program
    {
        static void Main()
        {
            var list = new List<string>() { "first", "second", "third", "fourth", "fifth" };
            Console.WriteLine("List<string>");
            foreach (string i in list) { Console.Write($" - {i}"); }

            var linkedlist = new LinkedList<int>(new[] { 0, 1, 2, 3, 4 });
            Console.WriteLine("\n\nLinkedList<int>");
            foreach (int i in linkedlist) { Console.Write($" - {i}"); }

            var queue = new Queue<string>(new[] { "zero", "one", "two", "three", "four" });
            Console.WriteLine("\n\nQueue<string>");
            foreach (string i in queue) { Console.Write($" - {i}"); }

            var stack = new Stack<byte>(new byte[] { 0, 1, 2, 3, 4 });
            Console.WriteLine("\n\nStack<byte>");
            foreach (byte i in stack) { Console.Write($" - {i}"); }

            var dictionary = new Dictionary<int, bool> { [1] = true, [2] = false, [3] = false, [0] = true, [15] = false };
            Console.WriteLine("\n\nDictionary<int, bool>");
            foreach (bool i in dictionary.Values) { Console.Write($" - {i}"); } 

            var sortedlist = new SortedList<string, object> { ["first"] = 1, ["second"] = "filler", ["third"] = 8, ["fourth"] = 0.0005, ["fifth"] = "space" };
            Console.WriteLine("\n\nSortedList<string, object>");
            foreach (var i in sortedlist.Values) { Console.Write($" - {i}"); }

            var hashset = new HashSet<string>() { "1", "2", "3", "4", "5" };
            Console.WriteLine("\n\nHashSet<string>");
            foreach (string i in hashset) { Console.Write($" - {i}"); }
        }
    }
    public struct KeyValue<TKey, TValue> where TKey : IComparable
    {
        public readonly TKey key;
        public readonly TValue value;

        public KeyValue(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
    class MyDictionary<TKey, TValue> where TKey : IComparable
    {
        List<KeyValue<TKey, TValue>> keyValues = new List<KeyValue<TKey, TValue>>();
        public object this[TKey inputKey]
        {
            get
            {
                foreach(KeyValue<TKey, TValue> i in keyValues)
                {
                    if (i.key.Equals(inputKey))
                        return i.value;
                }
                return new KeyNotFoundException();
            }
            set
            {
                for (int i = 0; i < keyValues.Count; i++)
                {
                    if (keyValues[i].key.Equals(inputKey))
                        keyValues[i] = new KeyValue<TKey, TValue>(inputKey, (TValue)Convert.ChangeType(value, typeof(TValue)));
                }
                keyValues.Add(new KeyValue<TKey, TValue>(inputKey, (TValue)Convert.ChangeType(value, typeof(TValue))));
            }
        }
    }

}
