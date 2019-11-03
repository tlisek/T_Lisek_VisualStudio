using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class Zadanie3
    {
        public void Run()
        {
            int num_string = 0;
            int num_int = 0;
            int num_float = 0;

            string line;

            do
            {
                Console.WriteLine("Podaj wartosc: ");

                line = Console.ReadLine();

                if (line == "-1") break;

                int result_int;
                if (int.TryParse(line, out result_int))
                {
                    num_int++;
                    continue;
                }

                float result_float;
                if (float.TryParse(line, out result_float))
                {
                    num_float++;
                    continue;
                }

                num_string++;

            }
            while (line != "-1");

            Console.WriteLine("Liczba int: {0}\nLiczba float: {1}\nLiczba string: {2}", num_int, num_float, num_string);

        }
    }
}
