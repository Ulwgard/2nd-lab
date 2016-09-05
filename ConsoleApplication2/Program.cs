using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string age = "\tмоя строка 2";
            string name = "\nмоя строка 1";
            string weight = "\aмоя строка 3";

            Console.Write(name);
            Console.Write(age);
            Console.Write(weight);


            Console.ReadKey();

        }
    }
}
