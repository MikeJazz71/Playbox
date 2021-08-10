﻿using System.Globalization;

namespace Playbox
{
    public class Calculator
    {
        public Calculator()
        {
            
        }

        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var num in numbers)
            {
                sum += num; 
            }

            return sum; 
        }
    }
}