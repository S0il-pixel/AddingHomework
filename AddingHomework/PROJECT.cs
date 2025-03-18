using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AddingHomework
{
    public class PROJECT
    {
        public static int Add(int i, int j)
        {
            return i + j;
        }


        public static int Subtract(int i, int j)
        {
            if (i < j)
            {
                return j - i;
            }
            else return i - j;
        }

        public static int Divide(int i, int j)
        {
            if (i < j)
            {
                return j / i;
            }
            else return i / j;
        }

        public static int Multiplication(int i, int j)
        {
            return i * j;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Add(4, 2));
            Console.WriteLine(Divide(4, 2));
            Console.WriteLine(Multiplication(4, 2));
            Console.WriteLine(Subtract(4, 2));
        }

    }
}
