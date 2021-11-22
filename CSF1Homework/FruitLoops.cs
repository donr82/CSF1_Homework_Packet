using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoops
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Fruit Loops Pt 1.");
            string[] fruit = { "apple", "banana", "kiwi", "pineapple", "lemon", "lime" };

            for (int i = 0; i<fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }

        }//end svm
    }//end class
}//end namespace