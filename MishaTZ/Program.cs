using System;
using System.Collections.Generic;

namespace MishaTZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EnderList<string> List = new EnderList<string>();
            List.add(2, "game");
            List.add(3, "vov");
            List.add(3, "game");
            List.add(4, "game");
            List.add(5, "game");
            List.add(6, "game");
            List.add(7, "game");
            List.add(8, "game");
            List.add(9, "game");
            List.add(10, "game");
           List.add(11, "game");
           List.Out(2);
            Console.WriteLine(List.Size);
            Console.WriteLine(List.Capaсity);

            System.Collections.Generic.List<int> list = new List<int>();
            list.Add(2);
            Console.WriteLine(list.Count);
        }
    }
}
