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
            Console.WriteLine("float value::" +f); //float

            Console.WriteLine("double value::"+d); //double

            Console.WriteLine("short value::"+shortVariable ); //short
            Console.WriteLine("boolean value"+boolVariable ); //boolean

            Console.WriteLine("char value::"+c ); //char

        }
      

        
    }
}
