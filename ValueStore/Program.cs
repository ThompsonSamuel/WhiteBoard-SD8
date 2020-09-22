using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace KeyValueStore
{
    public struct KeyValue
    {
        public readonly string key;
        public readonly object value;

        public KeyValue(string _key, object _value)
        {
            key = _key;
            value = _value;
        }
    }
    class MyDictionary
    {
        Dictionary<string, KeyValue> keyvalues = new Dictionary<string, KeyValue>();

        public object this[string inputKey]
        {
            set
            {
                if (keyvalues.ContainsKey(inputKey))
                {
                    keyvalues[inputKey] = new KeyValue(inputKey, value);
                }
                else
                    keyvalues.Add(inputKey, new KeyValue(inputKey, value));
            }
            get
            {
                if (keyvalues.ContainsKey(inputKey))
                {
                    return keyvalues[inputKey].value;
                }
                else
                    return new KeyNotFoundException();
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
        }
    }
}
