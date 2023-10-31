using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object_day2_homework
{
    //--- Exercise 2 ---
    //Class: Die
    //A 6-sided die that can be rolled!
    //- Consider how/if to keep track of your 6 sides.
    //- Implement a 'Roll()' method, which returns a random integer(1 - 6)
    //hint: The Random class is very helpful
    internal class Die
    {
       
        public int side=1;
        public Die() { }
        public int Roll() {
             Random rnd = new Random();
             side = rnd.Next(1, 6);
             return side;
        }

        public int RollNSide(int sideN)
        {
            Random rnd = new Random();
            side = rnd.Next(1, sideN);
            return side;
        }
    }
}
