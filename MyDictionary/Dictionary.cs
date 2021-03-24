using System;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values= new Value[0];

        }
        public void Add(Key _key,Value _value)
        {
            Key[] tempKey = keys;
            Value[] tempValue = values;

            keys = new Key[tempKey.Length + 1] ;
            values = new Value[tempValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }
            for (int x = 0; x < tempValue.Length; x++)
            {
                values[x] = tempValue[x];
            }
            keys[keys.Length - 1] = _key;
            values[values.Length - 1] = _value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

        public void ShowMe()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: " + keys[i] + " value : " + values[i]);
            }
        }
    }
}
