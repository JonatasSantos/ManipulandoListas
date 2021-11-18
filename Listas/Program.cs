using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            List<string> list2 = new List<string> { "Maria", "Alex" };

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(s => s[0] == 'A');
            string s2 = list.FindLast(s => s[0] == 'A');
            int pos1 = list.FindIndex(x => x[0] == 'A');
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            List<string> list3 = list.FindAll(x => x.Length == 5);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine("-------------------------------");
            foreach (string item in list3)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");
            Console.WriteLine("-------------------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-------------------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
