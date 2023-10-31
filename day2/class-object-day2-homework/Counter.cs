using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_object_day2_homework
{
    //--- Exercise 1 ---
    //Class: Counter
    //A simple tally counter that increments its value by 1 every click.
    //Create the class with the following functionality:
    //- 'Empty' constructor(no positional arguments required)
    //- 'value' variable
    //- 'Click()' method
    //- 'Reset()' method
    //Decide how to display your current value: After each function call? Only when asked?
    //Create an object and test your class!
    internal class Counter
    {
        public int value ;
        public Counter() {
            value = 0;
        }

        public int  Click() {
           
            value++;
            // Console.WriteLine(value);
            return value;
            
        }
        public int Reset() {
            value = 0;
           // Console.WriteLine(value);
            return value;
        }
    }
}
