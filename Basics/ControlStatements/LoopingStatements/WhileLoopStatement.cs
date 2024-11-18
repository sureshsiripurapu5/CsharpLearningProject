using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.ControlStatements.LoopingStatements
{
     class WhileLoopStatement
    {
        public static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

        }
    }
}

/* while is a iteration statement which is used when the iteration is not fixed*/
