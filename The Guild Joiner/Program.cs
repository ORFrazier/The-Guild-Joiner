using System;
using System.Collections.Generic;

namespace The_Guild_Joiner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others have joined the guild", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} have joined the guild", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} have joined the guild.", names[0]);
            else
                Console.WriteLine();


        }
    }
}
