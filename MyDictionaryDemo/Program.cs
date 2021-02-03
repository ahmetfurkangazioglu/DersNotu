using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> name = new MyDict<int, string>();
            name.Add(20, "Ahmet Furkan");
            name.Add(22, "Merve");
            name.Add(24, "Gamze");

           Console.WriteLine("Key numbar: "+name.Keyreturn[0]+" Name: "+ name.Valuesturn[0]);
            
        }
    }
}
