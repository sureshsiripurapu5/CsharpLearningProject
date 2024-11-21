using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics
{
    class CallByValue
    { 
        public void CallByValueExample(int val)
        {
            val = val * val;
            Console.WriteLine("Manupulating the value:");
            Console.WriteLine(val);
        }




       /* public static void Main(string[] args)
        {
            int originlValue = 25;
            CallByValue cb = new CallByValue();
            Console.WriteLine("Original value:" + originlValue);
            cb.CallByValueExample(originlValue);
            Console.WriteLine("After manipulation original value:"+originlValue );


        }*/
    }
}

/* In call by value or pass by value we are passing the copy of the value not the reference,
 * so if we make changes for the copy variable the original value wont gets modified */
