using System;
using System.Collections.Generic;

namespace Playbox
{
    public class FizzBuzz
    {

        public FizzBuzz()
        {
            List<object> FizzList = new List<object>();
        }

        public void fizzBuzz(int a, int b)
        {

            for (int i = a; i <= b; i++)
            {
                if (i % 15 == 0)
                { 
                    ;
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz\n");

                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz\n");

                }

                else
                {
                    Console.WriteLine(i + "\n");
                }
            }
        }
    }
}