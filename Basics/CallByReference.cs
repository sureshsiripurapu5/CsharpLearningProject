using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics
{
     class CallByReference
    {
        public void CallByReferenceExample(ref int val)
        {
            val = val * val;
            Console.WriteLine(" modification value:");
            Console.WriteLine(val);


        }
        public static void Main(string[] args)
        {
            int originalValue = 10;
            Console.WriteLine("The original value:"+originalValue);
            CallByReference callByReference = new CallByReference();
            callByReference.CallByReferenceExample(ref originalValue);
            Console.WriteLine("After modification the original value:"+originalValue );


        }
    }
}

/* Call by reference or pass by reference ,we are passing the reference so if we make any changes to the passed refrence,
 * it will affect to original value */
