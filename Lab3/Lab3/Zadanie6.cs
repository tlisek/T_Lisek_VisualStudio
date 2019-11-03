using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Zadanie6
    {
        public void Run()
        {
            Console.WriteLine("Podaj wejscie:");
            string input = Console.ReadLine();

            char[] cArray = input.ToCharArray();
            string output = String.Join(" ", cArray);
            Console.WriteLine(output);
        }
    }
}
