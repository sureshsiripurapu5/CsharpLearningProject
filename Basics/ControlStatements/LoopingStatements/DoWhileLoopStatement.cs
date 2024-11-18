using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearningProject.Basics.ControlStatements.LoopingStatements
{
    class DoWhileLoopStatement
    {
        public static void Main(string[] args)
        {
            int i = 1;

            do                                   
            {
                Console.WriteLine(i);
                i = i + 1;
            } while (i <= 10);
        }
    }
}

/* The do while is the iteration statement which is used when the numbers of iterations is not fixed, 
 * it will always executes once without checking the condition */
