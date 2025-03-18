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
        //I'm not totally sure what the instructions means, but I will sure do my best.
        public static int addition()
        {
            int j = 0;
           
            for(int i = 0; i < 1000; i++)
            {
                for(j = 0; j < 10000000; j++)
                {
                    j = j + j + 1;
                }
            }
            return j;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(addition());
        }
    }
}
