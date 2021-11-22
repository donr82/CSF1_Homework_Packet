using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fruit_Loops2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fruit Loops Pt 2");
            string[] fruit = { "apple", "banana", "kiwi", "pineapple", "lemon", "lime" };
            string dots = "";
            for (int i = 0; i < fruit.Length; i++)
            {
                if (i != 0)
                {
                    dots += ".";
                }

                Console.WriteLine(fruit[i]);
                Console.WriteLine(dots);
            }
        }
    }
}
