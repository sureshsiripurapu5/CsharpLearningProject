using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics
{
     class DataTypesAndVariables
    {
        int a = 10;
        int b= 20;

        short shortVariable = 11;
        bool boolVariable = false;
        char c = 'a';
        float f = 10.0f;
        double d = 10.00;
       

        public void PrintingValues()
        {
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine(f); //float

            Console.WriteLine(d); //decimal

            Console.WriteLine(shortVariable ); //short
            Console.WriteLine(boolVariable ); //boolean

            Console.WriteLine(c ); //char

        }

        
    }
}
