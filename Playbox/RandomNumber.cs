using System;
using System.Collections.Generic;

namespace Playbox
{
    public class RandomNumber

    {
        private Random _random = new Random(); 
       

        public RandomNumber()
        {
            
            

        }


        public int RandomNumGen(int min, int max)
        {
            return _random.Next(min, max); 
        }


    }
}