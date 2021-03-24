using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1,"Cengizhan");
            myDictionary.Add(2, "Tuncay");
            myDictionary.Add(3, "Miraç");

            Console.WriteLine(myDictionary.Count);
            myDictionary.ShowMe();
        }
    }
}
